using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace TreeUnitTest
{
    //This file contains test for the count function
    //Count should return the number of nodes of a given tree
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        //This will test the count of a single node with empty children.
        public void TestSingleEmptyNode()
        {
            //Create a TreeNode with no children
            TreeNode top = new TreeNode();
            Assert.AreEqual(1, ConsoleApp1.Program.Count(top));
        }

        [TestMethod]
        //This will test the count of a parent node with two children the count should return 3
        public void Test3Nodes()
        {
            TreeNode top = new TreeNode();
            top.Left = new TreeNode();
            top.Right = new TreeNode();

            Assert.AreEqual(3, Program.Count(top));
            Assert.AreEqual(3, Program.CountNodes(top));
        }

        [TestMethod]
        //This will test the count of a parent node with 4 children on the left and 3 on the right
        public void Test6Nodes()
        {
            TreeNode top = new TreeNode();
            TreeNode left = new TreeNode();
            TreeNode right = new TreeNode();

            //Create 3 children on left branch
            TreeNode leftRight = new TreeNode();
            top.Left = left;
            left.Left = new TreeNode();
            left.Right = leftRight;
            leftRight.Left = new TreeNode();

            //create 2 nodes onRight branch
            top.Right = right;
            right.Left = new TreeNode();
            right.Right = new TreeNode();

            Assert.AreEqual(8, Program.Count(top));
            Assert.AreEqual(8, Program.CountNodes(top));

        }

        [TestMethod]
        //This method will test the count returned when only two nodes are in the tree
        public void Test2Nodes()
        {
            TreeNode top = new TreeNode();
            top.Left = new TreeNode();

            Assert.AreEqual(2, Program.Count(top));
            Assert.AreEqual(2, Program.CountNodes(top));

        }

        [TestMethod]
        //This will test the count returned when a null node is passed to it
        public void TestNullCount()
        {
            Assert.AreEqual(0, Program.Count(null));
            Assert.AreEqual(0, Program.CountNodes(null));

        }

    }
}
