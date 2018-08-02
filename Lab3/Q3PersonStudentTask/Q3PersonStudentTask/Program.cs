using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3PersonStudentTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = false;

            Person myPerson = new Person();
            myPerson.Greet();

            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();

            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();

          
                Console.ReadLine();
        }
    }
}

