using BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace BinaryTreeTests
{
    [TestClass]
    public class EnumerationTests
    {
        [TestMethod]
        public void Enumerator_Of_Single()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            
            //Act
            var condition = tree.Contains(10);
            //Assert
            condition.ShouldBeFalse("Tree Should not contain 10 yet");

            tree.Add(10);

            //Act
            var newCondition = tree.Contains(10);
            //Assert
            newCondition.ShouldBeTrue("Tree should be contain 10");

            int count = 0;
            foreach (int item in tree)
            {
                count++;
                Assert.AreEqual(item, 10, "The item value should be 10");
            }
        }

    }
}
