using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using NUnit.Framework.Internal;
using System.Collections.Generic;
using System.Linq;

namespace FirstCodingChallenge.Tests
{
    [TestClass()]
    public class SinglyLinkedListTests
    {
        [TestMethod()]
        public void InsertTest_3_by_index_2()
        {
            // Arrange
            SinglyLinkedList<int> expected = new SinglyLinkedList<int>() { 1, 3, 5, 10, 3, 6 };

            // Act
            SinglyLinkedList<int> actual = new SinglyLinkedList<int>() { 1, 5, 10, 3, 6 };
            actual.Insert(3, 2);

            // Assert
            CollectionAssert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        [TestMethod()]
        public void AddTest_5()
        {
            // Arrange
            SinglyLinkedList<int> expected = new SinglyLinkedList<int>() { 1, 5, 10, 3, 6, 5 };

            // Act
            SinglyLinkedList<int> actual = new SinglyLinkedList<int>() { 1, 5, 10, 3, 6 };
            actual.Add(5);

            // Assert
            CollectionAssert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        [TestMethod()]
        public void RemoveTest_10()
        {
            SinglyLinkedList<int> data = new SinglyLinkedList<int>() { 1, 5, 10, 3, 6 };

            // Arrange
            bool expected = true;

            // Act
            bool actual = data.Remove(10);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ClearTest()
        {
            SinglyLinkedList<int> data = new SinglyLinkedList<int>() { 1, 5, 10, 3, 6 };

            // Arrange
            int expected = 0;

            // Act
            data.Clear();
            int actual = 0;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ContainsTest_10()
        {
            SinglyLinkedList<int> data = new SinglyLinkedList<int>() { 1, 5, 10, 3, 6 };

            // Arrange
            bool expected = true;

            // Act
            bool actual = data.Contains(10);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}