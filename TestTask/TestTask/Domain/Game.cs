using System;

namespace TestTask.Domain
{
    internal class Game
    {
        public static int[] KindOfShips = { 0, 0, 0, 0 };
        public static int GetCountOfShips()
        {
            var count = 0;
            for (var i = 0; i < Field.Ships.GetLength(0); i++)
            {
                for (var j = 0; j < Field.Ships.GetLength(1); j++)
                {
                    if (Field.Ships[i, j] != 1) 
                        continue;
                    count++;

                    var decks = Field.MarkShip(i, j, 0);
                    KindOfShips[decks]++;
                }
            }
            Console.WriteLine("game test");

            return count;
        }
    }
}
