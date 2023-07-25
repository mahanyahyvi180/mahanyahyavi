using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Effects of passing refrence to entire array :");
            Console.WriteLine("The value of the original array are:");


            foreach (var value in array)
            {
                Console.Write($"  {value}");
            }

            ModifyArray(array);
            Console.WriteLine("\n\nThe values of the modified array are:");


            foreach (var value in array)
            {
                Console.Write($" {value}");
            }

            Console.WriteLine("\n\nEffects of passing array element value:\n" + $"array[3] before ModifyElement:{array[3]}");

            ModifyElement(array[3]);
            Console.WriteLine($"array[3] after ModifyElement: {array[3]}");

        }

        static void ModifyArray(int[] array2)
        {
            for (var counter = 0; counter < array2.Length; ++counter)
            {
                array2[counter] *= 2;
            }
        }

        static void ModifyElement(int element)
        {
            element *= 2;
            Console.WriteLine($"value of element in ModifyElement:{element}");
            Console.ReadLine();

        }
    }
}
