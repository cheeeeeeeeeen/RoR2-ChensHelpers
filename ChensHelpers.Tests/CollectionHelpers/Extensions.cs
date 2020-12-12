using Chen.Helpers.CollectionHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Chen.Helpers.Tests.CollectionHelpers
{
    [TestClass]
    public class Extensions
    {
        [TestMethod]
        public void ConditionalAdd_AddsItem_ReturnsTrue()
        {
            List<int> list = new List<int>();
            const int newItem = 24;

            bool result = list.ConditionalAdd(newItem, listItem => listItem == newItem);

            CollectionAssert.Contains(list, newItem);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ConditionalAdd_DoesNotAddItem_ReturnsFalse()
        {
            List<int> list = new List<int>() { 7 };
            const int newItem = 10;

            bool result = list.ConditionalAdd(newItem, listItem => listItem <= newItem);

            CollectionAssert.DoesNotContain(list, newItem);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ConditionalAddRange_AddsAllItems_ReturnsTrue()
        {
            List<int> list = new List<int>() { 2, 4, 6 };
            int[] range = { 5, 7, 9 };

            bool result = list.ConditionalAddRange(range, (listItem, newItem) => listItem == newItem);

            CollectionAssert.IsSubsetOf(range, list.ToArray());
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ConditionalAddRange_AddsSomeItems_ReturnsFalse()
        {
            List<int> list = new List<int>() { 2, 4, 6 };
            int[] range = { 5, 7, 9, 2, 4, 6 };

            bool result = list.ConditionalAddRange(range, (listItem, newItem) => listItem == newItem);

            CollectionAssert.IsSubsetOf(range, list.ToArray());
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ConditionalAddRange_DoesNotAddItems_ReturnsFalse()
        {
            List<int> list = new List<int>() { 2, 4, 6 };
            int[] range = { 9, 10, 11 };

            bool result = list.ConditionalAddRange(range, (listItem, newItem) => listItem <= newItem);

            CollectionAssert.IsNotSubsetOf(range, list.ToArray());
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ConditionalRemove_RemovesItem_ReturnsTrue()
        {
            List<int> list = new List<int>() { 2, 4, 6 };
            const int item = 4;

            bool result = list.ConditionalRemove(item);

            CollectionAssert.DoesNotContain(list, item);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ConditionalRemove_DoesNothing_ReturnsFalse()
        {
            List<int> list = new List<int>() { 2, 4, 6 };
            const int itemToRemove = 5;
            int originalCount = list.Count;

            bool result = list.ConditionalRemove(itemToRemove);

            Assert.AreEqual(originalCount, list.Count);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Contains_ChecksExistenceOfExistingItem_ReturnsTrue()
        {
            int[] array = { 1, 2, 3 };
            const int itemCheck = 1;

            bool result = array.Contains(itemCheck);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Contains_ChecksExistenceOfNonExistingItem_ReturnsFalse()
        {
            int[] array = { 1, 2, 3 };
            const int itemCheck = 5;

            bool result = array.Contains(itemCheck);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ToList_ConvertArrayToList_ReturnsNewList()
        {
            int[] array = { 1, 2, 3 };

            List<int> result = array.ToList();

            Assert.IsInstanceOfType(result, typeof(List<int>));
            Assert.AreEqual(array.Length, result.Count);
            Assert.IsTrue(array[0] == result[0] && array[1] == result[1]);
        }
    }
}