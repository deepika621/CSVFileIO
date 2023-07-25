using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper;
using System.IO;
using System.Globalization;

//namespace CSVFileIO

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public static List<Student> GetStudent()
        {
            return new List<Student>
            {
                new Student {FirstName = "Kasarla", LastName = "Deepika", Email = "deepika@gmail.com"},
                new Student {FirstName = "Geddam", LastName = "Sirisha", Email = "sirisha@gmail.com"},
                new Student {FirstName = "Hemanth", LastName = "Kumar", Email = "hemanth.kumar@gmail.com" }
            };
        }
    }
