using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
 
namespace MasterAssignment.GenericDatabase.Tests
{
    [TestClass]
    public class CsvDatabaseTest
    {
        public object Success { get; private set; }
        public object FilePath { get; private set; }
        public object DatabaseHeader { get; private set; }
        public object FailurMessage { get; private set; }

        [TestMethod]
        public void CsvDatabaseInitializesCorrectly()
        {
            var FilePathTestValue = "TestingWithbogusFileName";

            var csvDatabase = new CsvDatabaseTest
            {
                FilePath = FilePathTestValue
            };
            csvDatabase.ShouldBeOfType<CsvDatabase>();
            csvDatabase.FilePath.ShouldBe(FilePathTestValue);
            csvDatabase.Success.ShouldBeFalse();
            csvDatabase.FailurMessage.ShouldBeEmpty();
            csvDatabase.DatabaseHeader.ShouldBeEmpty();
            csvDatabase.DatabaseRows.ShouldBeNull();


        }
    }
}
