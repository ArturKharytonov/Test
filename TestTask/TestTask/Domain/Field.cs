using System;

namespace TestTask.Domain
{
    internal class Field
    {
        public static int[,] Ships = {
            { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 0, 1, 0, 0 },
            { 0, 1, 0, 1, 0, 1, 0, 0, 0, 0 },
            { 0, 1, 0, 1, 0, 1, 0, 1, 1, 1 },
            { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 1, 1, 1, 1, 0, 1, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }
        };

        public static int MarkShip(int x, int y, int countOfDecks)
        {
            if (x < 0 || x >= Ships.GetLength(0) ||
                y < 0 || y >= Ships.GetLength(1) ||
                Ships[x, y] == 0)
                return countOfDecks - 1;
            
            Ships[x, y] = 0;

            countOfDecks = MarkShip(x - 1, y, countOfDecks + 1);
            countOfDecks = MarkShip(x + 1, y, countOfDecks + 1);
            countOfDecks = MarkShip(x, y - 1, countOfDecks + 1);
            countOfDecks = MarkShip(x, y + 1, countOfDecks + 1);
            Console.WriteLine("field test");

            return countOfDecks;
        }
    }
}

//{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }

//9