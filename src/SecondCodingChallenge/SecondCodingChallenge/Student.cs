using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SecondCodingChallenge
{
    public class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int AvgGrade { get; private set; }

        public Student(string firstName, string lastName, int avgGrade)
        {
            FirstName = firstName;
            LastName = lastName;
            AvgGrade = avgGrade;
        }

        public override string ToString()
{
            return $"|{FirstName + " " + LastName,5}||{AvgGrade,5}||{GetGradeAsLetter(),5}|";
        }

        string GetGradeAsLetter()
        {
            if (AvgGrade >= 90 && AvgGrade <= 100) return "A";
            else if (AvgGrade >= 80 && AvgGrade <= 89) return "B";
            else if (AvgGrade >= 70 && AvgGrade <= 79) return "C";
            else if (AvgGrade >= 60 && AvgGrade <= 69) return "D";
            else if (AvgGrade >= 0 && AvgGrade <= 59) return "F";
            return "Incorrect grade average";
        }
    }
}
