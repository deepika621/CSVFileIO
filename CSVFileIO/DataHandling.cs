using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace CSVFileIO
{
    public class DataHandling
    {
        public static void CsvDataHandle()
        {
            string importFilePath = @"C:\Users\deepi\source\repos\CSVFileIO\CsvFile.csv";
            string exportFilePath = @"C:\Users\deepi\source\repos\CSVFileIO\CsvFile1.csv";
            using(var reader=new StreamReader(importFilePath))
            using(var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<Student>().ToList();
                Console.WriteLine("Read Data Successfully");
                foreach (var item in records)
                {
                    Console.WriteLine(item.Email);
                }
                using (var writer = new StreamWriter(exportFilePath))
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecords(records);
                }
            }
        }
    }
}
