using System;
using System.Collections.ObjectModel;
using System.IO;
using MasterAssignment.Contracts;
 

namespace MasterAssignment.GenericDatabase
{
    public class CsvDatabase : IFileReader
    {
        public string FilePath { get; set; }

        public bool Success { get; private set; }

        public string FailerMessage { get; private set; }

        public string DatabaseHeader { get; private set; }

        public Collection<EmployeeDataRecord> DatabaseRows { get; private set; }

        public void LoadDatabaseTable()
        {
            using (var sr = new StreamReader(FilePath))
            {
                DatabaseHeader = sr.ReadLine();
                DatabaseRows = new Collection<EmployeeDataRecord>();

                do
                {
                    var oneLineOfText = sr.ReadLine();

                    if (oneLineOfText.IsNullOrEmpty())
                    {
                        break;
                    }
                    var oneLineParsedIntoArray = oneLineOfText.Split(separator: ',');
                    var oneLineParsedIntoStruct = new MasterAssignment.Contracts.EmployeeDataRecord
                    {
                        ID = oneLineParsedIntoArray[0].ToInt(),
                        FName = oneLineParsedIntoArray[1],
                        MName = oneLineParsedIntoArray[2],
                        LName = oneLineParsedIntoArray[3],
                        Address = oneLineParsedIntoArray[4],
                        City = oneLineParsedIntoArray[5],
                        State = oneLineParsedIntoArray[6],
                        ZipCode = oneLineParsedIntoArray[7]
                    };
                    DatabaseRows.Add(oneLineParsedIntoStruct);

                }
                while (true);
                Success = true;
            }
            try
            {

            }
            catch(Exception ex)
            {
                FailerMessage = ex.Message;
                Success = false;
            }

        }
    }
}
