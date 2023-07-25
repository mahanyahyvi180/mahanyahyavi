using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] responses = { 1, 2, 5, 4, 3, 5, 2, 1, 3, 3, 1, 4, 3, 3, 3, 2, 3, 3, 2, 14 };
            var frequency = new int[6];

            for (var answer = 0; answer < responses.Length; ++answer)
            {

                try
                {
                    ++frequency[responses[answer]];
                }
                catch (IndexOutOfRangeException ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine($"responses[{answer}={responses[answer]}\n");

                }
            }

            Console.WriteLine($"{"Rating"}{"Frequency",10}");

            for (var rating = 1; rating < frequency.Length; ++rating)
            {
                Console.WriteLine($"{rating,6}{frequency[rating],10}");
            }
            Console.ReadLine();

        }
    }
}
