﻿using BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
namespace BinaryTreeTests
{
    [TestClass]
    public class RemoveTests
    {
        [TestMethod]
        public void Remove_Head_Only_Node()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            tree.Add(4);
            //Act
            var condition = tree.Remove(4);
            //Assert
            condition.ShouldBeTrue("Remove should return true for found node");
            
        }

        [TestMethod]
        public void Remove_Missing_From_Tree()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //         4
            //       /   \
            //      2     8 
            //     / \    /
            //    1   3  6
            //          / \
            //         5   7   

            int[] values = new[]{4, 2, 1, 3, 8, 6, 7, 5};

            foreach(int i in values)
            {
                var newCondition = tree.Contains(10);
                newCondition.ShouldBeFalse("Tree should not contain 10");
                tree.Add(i);
            }
        }
    }
}