using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Faculty { get; set; }

    }

    public class StudentData
    {
        private static readonly List<Student> StudList = new List<Student>();
        static StudentData()
        {
            StudList.Add(new Student { Id = 1, Name = "Nume1", Faculty = "AC" });
            StudList.Add(new Student { Id = 2, Name = "Nume2", Faculty = "ETTI" });
            StudList.Add(new Student { Id = 3, Name = "Nume3", Faculty = "Info" });
            StudList.Add(new Student { Id = 4, Name = "Nume4", Faculty = "Mate" });
            StudList.Add(new Student { Id = 5, Name = "Nume5", Faculty = "MC" });
        }
        public StudentData()
        { }


        public List<Student> GetStudents()
        {
            return StudList;
        }

        public Student GetStudent(int id)
        {
            return StudList.Find(x => x.Id == id);
        }
    }
}