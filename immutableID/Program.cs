using System;
using System.Security.Cryptography.X509Certificates;
namespace immutable
{


    class Student
    {
        // auto-implemented properties
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // default constructor
        public Student()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
        }
        // parameterized constructor
        public Student(int i, string First, string Last)
        {
            Id = i;
            FirstName = First;
            LastName = Last;
        }
        public Student(int i)
        {
            Id = i;
            FirstName = "";
            LastName = "";
        }

    }
    class Program
    {
        static void DisplayStudent(Student student)
        {
            Console.WriteLine($"ID = {student.Id}, FirstName = {student.FirstName}, LastName = {student.LastName}");
        }

        static void Main(string[] args)
        {
            Student student1 = new Student(1);
            student1.FirstName = "RJ";
            student1.LastName = "Scarbrough";

            Student student2 = new Student(2,"Sam","Vasq");

            DisplayStudent(student1);
            DisplayStudent(student2);
        }
    }
}