using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryTree.lib;
using System.Collections.Generic;

namespace BinaryTree.Tests
{
    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        public void Insert()
        {
            BinaryTree tree = new BinaryTree();

            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);

            Assert.AreEqual("5 10 15", tree.ToString());
        }

        [TestMethod]
        public void Insert()
        {
            BinaryTree tree = new BinaryTree();

            tree.Insert(10);
            tree.Insert(10);

            Assert.AreEqual("10", tree.ToString());
        }

        [TestMethod]
        public void Contains()
        {
            BinaryTree tree = new BinaryTree(new List<int> { 10, 5, 15 });

            Assert.IsTrue(tree.Contains(5));
        }

        [TestMethod]
        public void Contains()
        {
            BinaryTree tree = new BinaryTree(new List<int> { 10, 5, 15 });

            Assert.IsFalse(tree.Contains(99));
        }

        [TestMethod]
        public void SumZero()
        {
            BinaryTree tree = new BinaryTree();

            Assert.AreEqual(0, tree.Sum);
        }

        [TestMethod]
        public void SumOfTree()
        {
            BinaryTree tree = new BinaryTree(new List<int> { 10, 5, 15 });

            Assert.AreEqual(30, tree.Sum);
        }
        
        [TestMethod]
        public void ToString()
        {
            BinaryTree tree = new BinaryTree(new List<int> { 10, 5, 15, 3, 7 });

            Assert.AreEqual("3 5 7 10 15", tree.ToString());
        }
    }
}