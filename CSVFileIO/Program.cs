using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace CSVFileIO
{
    class Program { 
        static void Main(string[] args)
        {
            /*var csvPath = @"C:\Users\deepi\source\repos\CSVFileIO\CsvFile.csv";
            using (var writer = new StreamWriter(csvPath))
            {
                using(var csvWriter=new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    var students = Student.GetStudent();
                    csvWriter.WriteRecords(students);
                }
            }*/
            DataHandling.CsvDataHandle();

        }
    }
}
