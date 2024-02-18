using System;
using TestTask.Domain;

namespace TestTask
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Total count of ships - {Game.GetCountOfShips()}");
            //Console.WriteLine($"One deck - {Game.KindOfShips[0]}\n" +
            //                  $"Two decks - {Game.KindOfShips[1]}\n" +
            //                  $"Three decks - {Game.KindOfShips[2]}\n" +
            //                  $"Four decks - {Game.KindOfShips[3]}");

            for (int i = 0; i < 100; i++)
            {
                Console.Write(i);

                if(i % 3 == 0 && i % 5 == 0)
                    Console.Write(" FizzBuzz");
                else if(i % 3 == 0)
                    Console.Write(" Fizz");
                else if(i % 5 == 0)
                    Console.Write(" Buzz");

                Console.WriteLine();
            }
        }
    }
}
