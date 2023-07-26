using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new[] {new Employee("Jason","Red",6000M),
                                  new Employee("Max","Green",7000.56M),
                                  new Employee("John","Brown",4000M),
                                  new Employee("Wendy","Indigo",3000M),
                                  new Employee("Ashley","Blue",2000.45M),
                                  new Employee("Taylor","Blue",5200.67M),
                                  new Employee("Jason","Red",4200.78M) };

            Console.WriteLine("Original array:");
            foreach (var element in employees)
            {
                Console.WriteLine(element);
            }

            var between5k7k =
                from e in employees
                where (e.MonthlySalary >= 5000M) && (e.MonthlySalary <= 7000M)
                select e;

            Console.WriteLine("\nEmployee earing in the range" + $"{5000:C}-{7000:C}per month:");

            foreach (var element in between5k7k)
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

            var LastName =
                from e in employees
                select e.LastName;

            Console.WriteLine("\nUnique employee last names:");
            foreach (var element in LastName.Distinct())
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
        }

    

                           
        }
    }

