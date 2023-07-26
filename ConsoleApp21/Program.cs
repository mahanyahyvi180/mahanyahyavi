using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new[] {new Employee("Jason","Red",5000M),
                                 new Employee("Max","Green",6000M),
                                 new Employee("Ashley","Indigo",4000.45M),
                                 new Employee("Jason","Blue",3000.34M),
                                 new Employee("Jack","Brown",5430.67M),
                                 new Employee("Luck","Indigo",7000M),
                                 new Employee("Wendy","Red",5266.56M) };

            Console.WriteLine("Original array:");

            foreach (var element in employees)
            {
                Console.WriteLine(element);
            }

            var Between4k6k =
               from e in employees
               where (e.MonthlySalary >= 4000M) && (e.MonthlySalary <= 6000M)
               select e;

            Console.WriteLine("\nEmployess earing in the range" + $"{4000:C}-{6000:C}per month:");
            foreach (var element in Between4k6k)
            {
                Console.WriteLine(element);
            }

            var nameSorted =
                from e in employees
                orderby e.LastName, e.FirstName
                select e;

            Console.WriteLine("\nFirst employee when sorted by name:");

            if (nameSorted.Any())
            {
                Console.WriteLine(nameSorted.First());
            }
            else
            {
                Console.WriteLine("not found");
            }

            var lastNames =
                from e in employees
                select e.LastName;

            Console.WriteLine("\nUnique employee last names:");
            foreach (var element in lastNames.Distinct())
            {
                Console.WriteLine(element);
            }

            var names =
                from e in employees
                select new { e.FirstName, e.LastName };

            Console.WriteLine("\nNames only:");
            foreach (var element in names)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
