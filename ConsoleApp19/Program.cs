using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new[] {new Employee("Jason","Red",5000M),
                                  new Employee("Max","Blue",4000.44M),
                                  new Employee("James","Green",7000M),
                                  new Employee("Luke","Blue",3000.23M),
                                  new Employee("Ashley","Indigo",6200M),
                                  new Employee("Anna","Brown",6000.34M),
                                  new Employee("yaser","Green",2000M) };

            Console.WriteLine("Original Array:");

            foreach (var element in employees)
            {
                Console.WriteLine(element);
            }

            var between4k6k =
                from e in employees
                where (e.MonthlySalary >= 4000M) && (e.MonthlySalary <= 6000M)
                select e;

            Console.WriteLine("\nEmployees earing in the range" + $"{4000:C}-{6000:C}per month:");

            foreach (var element in between4k6k)
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

            var lasNames =
                from e in employees
                select e.LastName;

            Console.WriteLine("\nUnique employee last names:");
            foreach (var element in lasNames.Distinct())
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
