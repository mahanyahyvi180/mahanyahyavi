using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1 , 2 , 3 };

            int[] firstArrayCopy = firstArray;

            Console.WriteLine("Test passing firstArray refrence by value");
            Console.Write("Contents of firstArray before calling FirstDouble:\n\t");
            Console.ReadLine();

            foreach (var element in firstArray)
            {
                Console.Write($"{element}");
            }

            FirstDouble(firstArray);

            Console.Write("\nContents of firstArray after calling FirstDouble\n\t");

            foreach (var element in firstArray)
            {
                Console.Write($"{element}");
            }

            if (firstArray == firstArrayCopy)
            {
                Console.WriteLine("\n\nThe refrences refer to the same array");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n\nThe refrence refer to different arrays");
                Console.ReadLine();
            }

            int[] secondArray = { 1 , 2 , 3 };

            int[] secondArrayCopy = secondArray;

            Console.WriteLine("\nTest passing secondArray refrence by refrence");

            Console.Write("Contents of secondArray before calling SecondDouble:\n\t");
            Console.ReadLine();

            foreach (var element in secondArray)
            {
                Console.Write($"{element}");
            }

            if (secondArray == secondArrayCopy)
            {
                Console.WriteLine("\n\nThe refrences refer to the same array");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n\nThe refrences refer to different arrays");
                Console.ReadLine();
            }
        }

        static void FirstDouble(int[] array)
        {
            for (var i = 0; i < array.Length; ++i)
            {
                array[i] *= 2;
            }

            array = new int[] { 11, 12, 13 };
            Console.ReadLine();
        }

        static void SecondDouble(ref int[] array)
        {

            for (var i = 0; i < array.Length; ++i)
            {
                array[i] *= 2;
            }

            array = new int[] { 11, 12, 13 };
            Console.ReadLine();
            
        }
        

    }
}
