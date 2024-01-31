using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentClassDemo
{

    public class Student
    {
        //-------------------------------------
        //Private Fields
        //-------------------------------------

        private string major;
        private int score1;
        private int score2;
        private int score3;
        private double average;
        private string studentFirstName;
        private string studentLastName;
        private string studentNumber;


        //-------------------------------------
        //  Properties
        //-------------------------------------
        //  2.2.	Use auto-properties for values that don’t need to call calculate:
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public string Major { get; set; }
        public double Average { get; private set; }

        //  2.3.	Use fully defined properties for values that need to call calculate:
        // Fully Qualified Property examples
        public int Score1
        {
            get { return score1; }
            set { score1 = value; CalcAverage(); }
        }
        public int Score2
        {
            get { return score2; }
            set { score2 = value; CalcAverage(); }
        }
        public int Score3
        {
            get { return score3; }
            set { score3 = value; CalcAverage(); }
        }

        //-------------------------------------
        //Constructors
        //-------------------------------------

        //default constructor
        public Student()
            : this("Number Pending", "TBD", "TBD", "Undeclared")
        {
        }

        //single parameter constructor
        public Student(string sID)
            : this(sID, "TBD", "TBD", "Undeclared")
        {
        }

        //constructor when we have student ID information and major
        public Student(string sID, string firstName, string lastName, string maj)
        {
            studentNumber = sID;
            studentFirstName = firstName;
            studentLastName = lastName;
            major = maj;
        }

        //constructor when we have student information and score information
        public Student(string sID, string firstName, string lastName,
            int s1, int s2, int s3, string maj)
            : this(sID, firstName, lastName, maj)
        {
            score1 = s1;
            score2 = s2;
            score3 = s3;
            CalcAverage();
        }

        //-------------------------------------
        //Accessors
        //-------------------------------------

        public string GetMajor()
        {
            return major;
        }

        public int GetScore1()
        {
            return score1;
        }

        public int GetScore2()
        {
            return score2;
        }

        public int GetScore3()
        {
            return score3;
        }

        public string GetFirstName()
        {
            return studentFirstName;
        }

        public string GetLastName()
        {
            return studentLastName;
        }

        public string GetStudentNumber()
        {
            return studentNumber;
        }

        public double GetAverage()
        {
            return average;
        }

        //-------------------------------------
        //Mutators
        //-------------------------------------
        public void SetMajor(string newMajor)
        {
            major = newMajor;
        }

        public void SetScore1(int newScore1)
        {
            score1 = newScore1;
            CalcAverage();
        }

        public void SetScore2(int newScore2)
        {
            score2 = newScore2;
            CalcAverage();
        }

        public void SetScore3(int newScore3)
        {
            score3 = newScore3;
            CalcAverage();
        }

        public void SetFirstName(string newFirstName)
        {
            studentFirstName = newFirstName;
        }

        public void SetLastName(string newLastName)
        {
            studentLastName = newLastName;
        }

        public void SetStudentNumber(string newStudentNumber)
        {
            studentNumber = newStudentNumber;
        }

        //-------------------------------------
        //Instance Methods
        //------------------------------------
        //  2.4.	Calculate method should remain unchanged:
        public void CalcAverage()
        {
            average = score1 + score2 + score3 / 3.0;
        }

        //  2.5.	ToString may need to use Auto Properties instead of field names:
        public override string ToString()
        {
            return "ToString output: " + FirstName + " " + LastName + " Major: " + Major + " Average: " + Average;
        }

        // Do another tech from the live demo
        public static bool DoAnother()
        {
            Console.WriteLine("Do you want to enter another student? (y/n): ");
            string? answer = Console.ReadLine();
            if (string.IsNullOrEmpty(answer)) 
            { 
                return false;
            }
            return answer.ToLower()[0] == 'y';
        }
    }
}
