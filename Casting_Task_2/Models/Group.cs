using System;
using System.Collections.Generic;
using System.Text;

namespace Casting_Task_2.Models
{
    internal class Group
    {
        private static int _no = 100;
        public string No { get; }
        private Student[] Students;
        public List<int> point;

        public Group() 
        {
            _no++;
            No= $"AP{_no}";

            Students = new Student[0];

        }

        public void AddStudent(Student student)
        {
            Students[Students.Length - 1] = student;
            Array.Resize(ref Students, Students.Length + 1);
        }

        public Student[] GetAllStudents()
        {
            return Students;
        }

        public void Sort()
        {
            point = new List<int>();
        }
    }
}
