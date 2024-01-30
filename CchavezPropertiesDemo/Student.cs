using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassDemo
{
    class Student
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
        public void CalcAverage()
        {
            average = score1 + score2 + score3 / 3.0;
        }
    }
}
