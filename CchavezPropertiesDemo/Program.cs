using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace StudentClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            //  myStudent.SetMajor("Computer Programming");
            // Property call using set method example
            myStudent.Major = "Computer Programming";
            //  Normal Set method call not using the property
            //  myStudent.SetMajor("Computer Programming");

            Student myOtherStudent = new Student();
            myOtherStudent.SetMajor("Art History");

            // Propery call using Get method example
            Console.WriteLine("My Major is {0}.", myStudent.Major);
            //  normal Get method call not using the property
            //  Console.WriteLine("My Major is {0}.", myStudent.GetMajor);
            Console.WriteLine("The other student's major is {0}.", myOtherStudent.GetMajor());


            //  3.1.	Create a list of students the use a do-another loop to get
            //  each students information.Use the properties we created to store
            //  the information.At the end use a foreach to loop through all the
            //  students and display their information:
            List<Student> students = new List<Student>();
            do
            {
                Student st = new Student();
                st.FirstName = GetInput("First Name");
                st.LastName = GetInput("Last Name");
                st.Major = GetInput("Major");
                st.StudentNumber = GetInput("Student Number");
                st.Score1 = int.Parse(GetInput("Score 1"));
                st.Score2 = int.Parse(GetInput("Score 2"));
                st.Score3 = int.Parse(GetInput("Score 3"));
                students.Add(st);
            } while (Student.DoAnother());

            Console.WriteLine("Student Averages:");
            foreach (Student st in students)
            {
                Console.WriteLine(st.ToString());
            }
        }

    
        static private string GetInput(string prompt)
        {
            Console.Write(prompt + ": ");
            return Console.ReadLine();
        }


    }
}


