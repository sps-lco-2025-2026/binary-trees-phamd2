using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryTree.lib;
using System.Collections.Generic;

namespace BinaryTree.Tests
{
    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        public void Insert_AddsValuesCorrectly()
        {
            BinaryTree tree = new BinaryTree();

            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);

            Assert.AreEqual("5 10 15", tree.ToString());
        }

        [TestMethod]
        public void Insert_IgnoresDuplicateValues()
        {
            BinaryTree tree = new BinaryTree();

            tree.Insert(10);
            tree.Insert(10);

            Assert.AreEqual("10", tree.ToString());
        }

        [TestMethod]
        public void Contains_ReturnsTrue_WhenValueExists()
        {
            BinaryTree tree = new BinaryTree(new List<int> { 10, 5, 15 });

            Assert.IsTrue(tree.Contains(5));
        }

        [TestMethod]
        public void Contains_ReturnsFalse_WhenValueDoesNotExist()
        {
            BinaryTree tree = new BinaryTree(new List<int> { 10, 5, 15 });

            Assert.IsFalse(tree.Contains(99));
        }

        [TestMethod]
        public void Sum_ReturnsZero_ForEmptyTree()
        {
            BinaryTree tree = new BinaryTree();

            Assert.AreEqual(0, tree.Sum);
        }

        [TestMethod]
        public void Sum_ReturnsTotal_ForTreeWithValues()
        {
            BinaryTree tree = new BinaryTree(new List<int> { 10, 5, 15 });

            Assert.AreEqual(30, tree.Sum);
        }

        [TestMethod]
        public void ToString_ReturnsEmptyString_ForEmptyTree()
        {
            BinaryTree tree = new BinaryTree();

            Assert.AreEqual(string.Empty, tree.ToString());
        }

        [TestMethod]
        public void ToString_ReturnsValuesInOrder()
        {
            BinaryTree tree = new BinaryTree(new List<int> { 10, 5, 15, 3, 7 });

            Assert.AreEqual("3 5 7 10 15", tree.ToString());
        }
    }
}