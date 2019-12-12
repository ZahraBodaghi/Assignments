using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MasterAssignment.Contracts
{
    public interface IFileReader
    {
        string FilePath { get; set; }
        bool Success { get; }
        string FailerMessage { get; }
        void LoadDatabaseTable();
        string DatabaseHeader { get; }
        Collection<EmployeeDataRecord> DatabaseRows { get; }
    }
}
