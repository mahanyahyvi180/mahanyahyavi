using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gradesArray = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };

            var myGradeBook = new GradeBook("CS101 Introduction to c# programing", gradesArray);

            myGradeBook.DisplayMessage();
            myGradeBook.processGrades();

            Console.ReadLine();
        }
    }
}
