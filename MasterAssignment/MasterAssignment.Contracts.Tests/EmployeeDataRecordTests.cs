using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;


namespace MasterAssignment.Contracts.Tests
{
    [TestClass]
    public class EmployeeDataRecordTests
    {
        [TestMethod]
        public void EmployeeDataRecordTest()
        {
            var employeeDataRecord = new EmployeeDataRecord
            {
                ID = 101,
                FName = "Reynolds",
                MName = "E",
                LName = "Prof",
                Address = "College Park Drive",
                City = "Conroe",
                State = "TX",
                ZipCode ="77450"
            };

            employeeDataRecord.ShouldBeType<EmployeeDataRecord>();

            employeeDataRecord.ID.ShouldBe(expected: 101);
            employeeDataRecord.LName.ShouldBe(expected: "Reynolds");

        }
    }
}
