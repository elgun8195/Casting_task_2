using System;
using System.Collections.Generic;
using System.Text;

namespace Casting_Task_2.Models
{
    internal class Student
    {
        private static int _id;        
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Point { get; set; }






        public Student(string name,string surname,double point)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Point = point;
        }


        public void Showinfo()
        {
            Console.WriteLine($"Id: {Id} - Name: {Name} - Surname: {Surname} - Age: {Age} - Point: {Point}");
        }

        public static bool operator  >(Student student, Student student1)
        {
            bool result = student.Point > student1.Point;
            return result;
        }
        public static bool operator < (Student student, Student student1)
        {
            bool result = student.Point < student1.Point;
            return result;
        }
    }
}
