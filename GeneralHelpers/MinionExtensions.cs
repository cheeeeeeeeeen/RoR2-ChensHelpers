using Chen.Helpers.UnityHelpers;
using R2API.Networking;
using R2API.Networking.Interfaces;
using RoR2;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using static Chen.Helpers.HelperPlugin;
using Object = UnityEngine.Object;

namespace Chen.Helpers.GeneralHelpers
{
    /// <summary>
    /// Useful extensions related to Minions.
    /// </summary>
    public static class MinionExtensions
    {
        /// <summary>
        /// Loops through the minions and fellow minions, then applies processing for each through an action.
        /// </summary>
        /// <param name="ownerOrMinion">Master of the minions or a fellow minion</param>
        /// <param name="logic">Code to apply for each minion</param>
        public static void LoopMinions(this CharacterMaster ownerOrMinion, Action<CharacterMaster> logic)
        {
            MinionOwnership thisMinionOwnership = ownerOrMinion.minionOwnership;
            if (!thisMinionOwnership) return;
            MinionOwnership[] minionOwnerships = Object.FindObjectsOfType<MinionOwnership>();
            foreach (MinionOwnership minionOwnership in minionOwnerships)
            {
                if (minionOwnership && minionOwnership.ownerMaster)
                {
                    bool ownerCondition = !thisMinionOwnership.ownerMaster && minionOwnership.ownerMaster == ownerOrMinion;
                    bool minionCondition = thisMinionOwnership.ownerMaster && minionOwnership.ownerMaster == thisMinionOwnership.ownerMaster;
                    if (ownerCondition || minionCondition)
                    {
                        CharacterMaster minion = minionOwnership.GetComponent<CharacterMaster>();
                        logic(minion);
                    }
                }
            }
        }

        /// <summary>
        /// Fetches all the minions and fellow minions, then returns a list of the minions' component.
        /// </summary>
        /// <typeparam name="T">Component to match</typeparam>
        /// <param name="ownerOrMinion">Master of the minions</param>
        /// <returns>List of components of the minions</returns>
        public static List<T> GetAllMinionComponents<T>(this CharacterMaster ownerOrMinion) where T : Component
        {
            List<T> list = new List<T>();
            LoopMinions(ownerOrMinion, (minion) =>
            {
                T component = minion.gameObject.GetComponent<T>();
                if (component) list.Add(component);
            });
            return list;
        }

        /// <summary>
        /// Assigns a new owner to the minion. This needs to be called on both the Server and the Client.
        /// If transmit is true, it only needs to be called on the server.
        /// The queuing system provides a way to ensure that all clients will sync the owner. This is a slow process though.
        /// Only set useQueue to true if the client cannot see the objects and returns a warning of the object being null.
        /// </summary>
        /// <param name="minion">Minion to set a new owner with</param>
        /// <param name="newOwner">New owner of the minion</param>
        /// <param name="transmit">Determines whether the server would send a sync message to other clients</param>
        /// <param name="useQueue">Tells the client to use a queuing system if transmit is true</param>
        public static void AssignOwner(this CharacterMaster minion, CharacterMaster newOwner, bool transmit = false, bool useQueue = false)
        {
            if (NetworkServer.active)
            {
                minion.minionOwnership.SetOwner(newOwner);
                if (transmit)
                {
                    NetworkIdentity netMinion = minion.gameObject.GetComponent<NetworkIdentity>();
                    NetworkIdentity netOwner = newOwner.gameObject.GetComponent<NetworkIdentity>();
                    if (!netMinion || !netOwner)
                    {
                        Log.Warning("AssignOwner with transmit: NetworkIdentity is missing.");
                        return;
                    }
                    new SyncOwner(netMinion.netId, netOwner.netId, useQueue).Send(NetworkDestination.Clients);
                }
            }
            else
            {
                NetworkIdentity netOwnerMaster = newOwner.gameObject.GetComponent<NetworkIdentity>();
                if (!netOwnerMaster)
                {
                    Log.Warning("AssignOwner: Network Identity is missing!");
                    return;
                }
                minion.minionOwnership.ownerMasterId = netOwnerMaster.netId;
                MinionOwnership.MinionGroup.SetMinionOwner(minion.minionOwnership, netOwnerMaster.netId);
            }
        }

        internal static void ProcessAssignment(GameObject minionObject, GameObject ownerObject, string caller)
        {
            CharacterMaster minion = minionObject.GetComponent<CharacterMaster>();
            if (!minion) Log.Warning($"{caller}: minion is null.");
            CharacterMaster owner = ownerObject.GetComponent<CharacterMaster>();
            if (!owner) Log.Warning($"{caller}: owner is null.");
            if (!minion || !owner) return;
            minion.AssignOwner(owner);
        }

        internal class SyncOwner : INetMessage
        {
            private NetworkInstanceId minionNetId;
            private NetworkInstanceId ownerNetId;
            private bool useQueue;

            public SyncOwner()
            {
            }

            public SyncOwner(NetworkInstanceId minionNetId, NetworkInstanceId ownerNetId, bool useQueue)
            {
                this.minionNetId = minionNetId;
                this.ownerNetId = ownerNetId;
                this.useQueue = useQueue;
            }

            public void Serialize(NetworkWriter writer)
            {
                writer.Write(minionNetId);
                writer.Write(ownerNetId);
                writer.Write(useQueue);
            }

            public void Deserialize(NetworkReader reader)
            {
                minionNetId = reader.ReadNetworkId();
                ownerNetId = reader.ReadNetworkId();
                useQueue = reader.ReadBoolean();
            }

            public void OnReceived()
            {
                if (NetworkServer.active) return;
                if (useQueue)
                {
                    OwnershipSyncer syncer = Run.instance.gameObject.GetOrAddComponent<OwnershipSyncer>();
                    syncer.Add(minionNetId, ownerNetId);
                }
                else
                {
                    GameObject minionObject = Util.FindNetworkObject(minionNetId);
                    GameObject ownerObject = Util.FindNetworkObject(ownerNetId);
                    if (!minionObject) Log.Warning("SyncOwner: minionObject or ownerObject is null.");
                    if (!ownerObject) Log.Warning("SyncOwner: ownerObject is null.");
                    if (!minionObject || !ownerObject) return;
                    ProcessAssignment(minionObject, ownerObject, "SyncOwner");
                }
            }
        }

        internal class OwnershipSyncer : MonoBehaviour
        {
            private readonly Queue<OwnerMinionPair> netIds = new Queue<OwnerMinionPair>();

            public void Add(NetworkInstanceId minionNetId, NetworkInstanceId ownerNetId)
            {
                netIds.Enqueue(new OwnerMinionPair(minionNetId, ownerNetId));
            }

            private void FixedUpdate()
            {
                if (netIds.Count > 0)
                {
                    OwnerMinionPair pair = netIds.Dequeue();
                    GameObject minionObject = Util.FindNetworkObject(pair.minionNetId);
                    GameObject ownerObject = Util.FindNetworkObject(pair.ownerNetId);
                    if (!minionObject || !ownerObject) netIds.Enqueue(pair);
                    else ProcessAssignment(minionObject, ownerObject, "OwnershipSyncer");
                }
                else Destroy(this);
            }

            private struct OwnerMinionPair
            {
                public NetworkInstanceId minionNetId;
                public NetworkInstanceId ownerNetId;

                public OwnerMinionPair(NetworkInstanceId minionNetId, NetworkInstanceId ownerNetId)
                {
                    this.minionNetId = minionNetId;
                    this.ownerNetId = ownerNetId;
                }
            }
        }
    }
}
