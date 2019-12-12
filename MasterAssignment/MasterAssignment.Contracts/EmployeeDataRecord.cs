using System;

namespace MasterAssignment.Contracts
{
    public class EmployeeDataRecord
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public void ShouldBeType<T>()
        {
            throw new NotImplementedException();
        }
    }
}
