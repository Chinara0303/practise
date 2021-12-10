using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Student
    {
        public string Fullname;
        public int Course;
        public string Subject;
        public string University;
        public string Email;
        public  int Phonenumber;

        public Student(string fullname, string university, int course, string subject, string email, int phonenumber)
        {
            Fullname = fullname;
            University = university;
            Course = course;
            Subject = subject;
            Email = email;
            Phonenumber = phonenumber;
        }

        

        public void All(string Fullname, int Course, string Subject,string University,string Email, int Phonenumber)
        {
            Console.WriteLine($"{Fullname} {Course} {Subject} {University} {Email} {Phonenumber}");
        }


    }
}
