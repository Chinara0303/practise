using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("Chinara Ibadova", "ASPU", 5,"Mathematic",  "chinaraei@code.edu.az",0504822164);
            stu1.All(stu1.Fullname,stu1.Course,stu1.Subject, stu1.University,stu1.Email,stu1.Phonenumber);

        }
    }
}
