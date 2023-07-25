using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
             private int[,] grades;

        public string CourseName { get; }

        public GradeBook(string name, int[,] gradesArray)
        {
            CourseName = name;
            grades = gradesArray;
        }

        public void DisplayMessage()
        {
            Console.WriteLine($"Welcome to the grade book for\n{CourseName}!\n");
        }

        public void processGrades()
        {

            OutpuGrades();

            Console.WriteLine($"\nLowest grade in the grade book is{GetMinimum()}" + $"\nHighest grade in the grade book is {GetMaximum()}\n");

            OutputBarChart();
        }



    }
}
}
