using Casting_Task_2.Models;
using System;

namespace Casting_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Elgun","Qocayev",99);
            student.Age = 20;

            Student student2 = new Student("Sovket", "Aliyeva", 100);
            student2.Age = 22;

            Student student3 = new Student("Imran", "Asadov", 100);
            student3.Age = 24;

            Student student4 = new Student("Perviz", "Musayev", 100);
            student4.Age = 26;

            Group group = new Group();
            group.AddStudent(student);

            
        }
    }
}
