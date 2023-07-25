using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class DeckofCardsTest
    {
        static void Main(string[] args)
        {
            var myDeckOfCards = new DeckofCardsTest();

            myDeckOfCards.Shuffle();

            for (var i = 0; i < 52; ++i)
            {
                Console.Write($"{myDeckOfCards.DealCard(),-19}");

                if ((i + 1) % 4 == 0)
                {
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        
        }

        private void Shuffle()
        {
            throw new NotImplementedException();
        }

        private object DealCard()
        {
            throw new NotImplementedException();
        }
    }
}
