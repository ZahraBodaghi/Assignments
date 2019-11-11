using NUnit.Framework;
using CommonnFramework.Core;
using CommonnFramework.Core.Extensions;
using Shouldly;
/*
 * Zahra Bodaghi
 */

namespace CommonnFramework.Core.Tests.Extensions
{
    [TestFixture]
    public class StringExtensionsTests
    {
        #region IsNullOrEmpty
        [TestCase]
        public void IsNullOrEmpty_IsNull()
        {
            //Arrange
            string testCondition = null;
            //Act
            var actualResult = testCondition.IsNullOrEmpty();
            //Assert
            actualResult.ShouldBeTrue();
        }
        [TestCase]
        public void IsNullOrEmpty_IsEmpty()
        {
            //Arrange
            string testCondition = "";
            //Act
            var actualResult = testCondition.IsNullOrEmpty();
            //Assert
            actualResult.ShouldBeTrue();
        }
        [TestCase]
        public void IsNullOrEmpty_IsSpaces()
        {
            //Arrange
            string testCondition = "         ";
            //Act
            var actualResult = testCondition.IsNullOrEmpty();
            //Assert
            actualResult.ShouldBeFalse();
        }
        [TestCase]
        public void IsNullOrEmpty_HasContent()
        {
            //Arrange
            string testCondition = "Zahra Bodaghi";
            //Act
            var actualResult = testCondition.IsNullOrEmpty();
            //Assert
            actualResult.ShouldBeFalse();
        }
        #endregion
        #region IsNullOrWhiteSpace
        [TestCase]
        public void IsNullOrWhiteSpace_IsNull()
        {
            //Arrange
            string testCondition = null;
            //Act
            var actualResult = testCondition.IsNullOrWhiteSpace();
            //Assert
            actualResult.ShouldBeTrue();
        }
        [TestCase]
        public void IsNullOrWhiteSpace_IsEmpty()
        {
            //Arrange
            string testCondition = "";
            //Act
            var actualResult = testCondition.IsNullOrWhiteSpace();
            //Assert
            actualResult.ShouldBeTrue();
        }
        [TestCase]
        public void IsNullOrWhiteSpace_IsSpaces()
        {
            //Arrange
            string testCondition = "         ";
            //Act
            var actualResult = testCondition.IsNullOrWhiteSpace();
            //Assert
            actualResult.ShouldBeTrue();
        }
        [TestCase]
        public void IsNullOrWhiteSpace_HasContent()
        {
            //Arrange
            string testCondition = "Zahra Bodaghi";
            //Act
            var actualResult = testCondition.IsNullOrWhiteSpace();
            //Assert
            actualResult.ShouldBeFalse();
        }
        #endregion
        #region Left
        [TestCase]
        public void Left_Normal()
        {
            //Arrange
            string testCondition = "Zahra Bodaghi";
            int numCharacters = 13;
            //Act
            var actualResult = testCondition.Left(numCharacters);
            //Assert
            actualResult.ShouldBe(expected: "Zahra Bodaghi");
        }
        [TestCase]
        public void Left_IsNull()
        {
            //Arrange 
            string testCondition = null;
            int numCharacters = 3;
            //Act
            var actualResult = testCondition.Left(numCharacters);
            //Assert 
            actualResult.ShouldBeNull();
        }
        [TestCase]
        public void Left_NoCharacters()
        {
            //Arrange 
            string testCondition = "";
            int numCharacters = 3;
            //Act
            var actualResult = testCondition.Left(numCharacters);
            //Assert 
            actualResult.ShouldBeEmpty();
        }
        [TestCase]
        public void Left_TooManyCharacters()
        {
            //Arrange 
            string testCondition = "This is the 3rd Assignment by Zahra Bodaghi which had been done in the third week";
            int numCharacters = 3;
            //Act
            var actualResult = testCondition.Left(numCharacters);
            //Assert 
            actualResult.ShouldBe(expected:"Thi");
        }
        #endregion
        #region Right
        [TestCase]
        public void Right_Normal()
        {
            //Arrange
            string testCondition = "Zahra Bodaghi";
            int numCharacters = 13;
            //Act
            var actualResult = testCondition.Right(numCharacters);
            //Assert
            actualResult.ShouldBe(expected: "Zahra Bodaghi");
        }
        [TestCase]
        public void Right_IsNull()
        {
            //Arrange 
            string testCondition = null;
            int numCharacters = 3;
            //Act
            var actualResult = testCondition.Right(numCharacters);
            //Assert 
            actualResult.ShouldBeNull();
        }
        [TestCase]
        public void Right_NoCharacters()
        {
            //Arrange 
            string testCondition = "";
            int numCharacters = 3;
            //Act
            var actualResult = testCondition.Right(numCharacters);
            //Assert 
            actualResult.ShouldBeEmpty();
        }
        [TestCase]
        public void Right_TooManyCharacters()
        {
            //Arrange 
            string testCondition = "This is the 3rd Assignment by Zahra Bodaghi which had been done in the third week";
            int numCharacters = 3;
            //Act
            var actualResult = testCondition.Right(numCharacters);
            //Assert 
            actualResult.ShouldBe(expected: "Thi");
        }
        #endregion


    }
}
