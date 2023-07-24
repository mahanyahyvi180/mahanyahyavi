using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            for (var counter = 0; counter < array.Length; ++counter)
            {
                array[counter] = initialValue + increment * counter;
                Console.ReadLine();
            }
            Console.WriteLine($"{"Index"}{"Value,8"}");
            Console.ReadLine();
        
                for (int counter = 0; counter < array.Length; ++counter)
                {
                    Console.WriteLine($"{counter,5}{array[counter],8}");
                    Console.ReadLine();
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }

    }


   
