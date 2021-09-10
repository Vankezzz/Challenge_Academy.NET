using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SecondCodingChallenge
{
    static class Program
    {

        static void Main(string[] args)
        {
            List<Student> students;
            bool state = false;
            try
            {
                while (state == false)
                {
                    Console.WriteLine("Hi, input a number of students (number is integer) ");

                    //Integer check
                    state = int.TryParse(Console.ReadLine(), out int students_count);
                    if (!state) continue;

                    //Set capacity
                    students = new List<Student>(students_count);

                    Console.WriteLine("How many tests were administered to the students? (number is integer)");
                    
                    //Integer check
                    state = int.TryParse(Console.ReadLine(), out int tests_count);
                    if (!state) continue;

                    for (int student = 0; student < students_count; student++)
                    {
                        Console.WriteLine($"\nStudent № {student + 1}");

                        Console.WriteLine($"Input the first name");
                        string first_name = Console.ReadLine();

                        Console.WriteLine($"Input the last name");
                        string last_name = Console.ReadLine();

                        //Write at first time a note in table with numerical and letter grade
                        if (student == 0) Console.WriteLine(GetNote());


                        List<int> grades;

                        do
                        {
                            //Set capacity
                            grades = new List<int>(tests_count);

                            Console.WriteLine($"Input by \";\" each numerical {tests_count} grade(s) of the tests for the {first_name} {last_name} (For instance, 80; 90; 50)");

                            // Filtering grade:
                            // 1. Remove whitespace
                            // 2. Integer check
                            // 2. Range of grade (0 - 100)
                            Console.ReadLine().RemoveWhitespace().Split(";").Where(num => int.TryParse(num, out int inum) && inum <=100 && inum >= 0).ToList().ForEach(grade => grades.Add(Convert.ToInt32(grade)));

                        }
                        while (grades.Count != tests_count);

                        students.Add(new Student(first_name, last_name, (int)Math.Round(grades.Average())));

                    }
                    Console.WriteLine($"\n Tables with results");
                    students.ForEach(student => Console.WriteLine(student));
                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static string GetNote()
        {
            StringBuilder table = new StringBuilder();
            table.AppendLine();
            table.AppendLine("Note, input numerical grade based on the following table.");
            table.AppendLine($"|{"Numerical Grade",5}|{"Letter Grade",5}|");
            table.AppendLine($"|{"    90 - 100   ",5}|{"      A     ",5}|");
            table.AppendLine($"|{"    80 - 89    ",5}|{"      B     ",5}|");
            table.AppendLine($"|{"    70 - 79    ",5}|{"      C     ",5}|");
            table.AppendLine($"|{"    60 - 69    ",5}|{"      D     ",5}|");
            table.AppendLine($"|{"     0 - 59    ",5}|{"      F     ",5}|");
            table.AppendLine();

            return table.ToString();
        }

        public static string RemoveWhitespace(this string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
    }

}
