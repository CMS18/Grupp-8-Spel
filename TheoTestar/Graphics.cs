using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoTestar
{
    class Graphics
    {
        
        public char m1 = '^';
        public char r1 = '~';
        public char b1 = '=';
        public char f1 = '"';
        public char s1 = '¨';
        public char rB = '-';
        public char w1 = '|';
        public char k1 = '+';
        public char l1 = '¤';
        public char t1 = '*';
        public char p1 = '!';
        public char nO = 'X';
    

        private static char[,] MapArray(char m1, char r1, char b1, char f1, char s1, char rB, char w1, char k1, char l1, char t1)
        {
            return new char[14, 14]

            {
            {k1    ,rB, rB, rB, rB, rB, rB, rB, rB, rB, rB, rB, rB,     k1 },

            {w1,    m1, m1, m1, m1, m1, m1, m1, m1, m1, m1, m1, m1,     w1 },
            {w1,    m1, m1, f1, r1, f1, m1, m1, m1, f1, t1, t1, m1,     w1 },
            {w1,    m1, f1, f1, b1, f1, m1, m1, t1, t1, t1, t1, m1,     w1 },
            {w1,    r1, r1, f1, r1, f1, m1, m1, t1, f1, f1, f1, m1,     w1 },
            {w1,    f1, b1, f1, r1, f1, s1, s1, f1, f1, f1, f1, m1,     w1 },
            {w1,    f1, r1, r1, r1, r1, m1, m1, r1, r1, b1, r1, m1,     w1 },
            {w1,    f1, b1, f1, r1, r1, m1, m1, m1, m1, s1, s1, m1,     w1 },
            {w1,    r1, r1, f1, f1, m1, m1, l1, l1, m1, s1, s1, m1,     w1 },
            {w1,    r1, t1, t1, f1, m1, l1, l1, s1, s1, s1, s1, m1,     w1 },
            {w1,    t1, t1, t1, t1, m1, l1, s1, s1, l1, m1, t1, m1,     w1 },
            {w1,    t1, t1, t1, r1, m1, l1, l1, l1, l1, m1, t1, m1,     w1 },
            {w1,    t1, m1, m1, m1, m1, m1, m1, m1, m1, m1, f1, m1,     w1 },

            {k1,    rB, rB, rB, rB, rB, rB, rB, rB, rB, rB, rB, rB,     k1 },
            };
        }
        private static void DesignMap(char m1, char r1, char b1, char f1, char s1, char rB, char w1, char k1, char l1, char t1, char p1, char nO, char[,] map)
        {
            int coordinate = 0;
            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9 X 1 2 3");
            for (int h = 0; h < map.GetLength(1); h++)
            {
                Console.ResetColor();
                if (coordinate <= 9)
                {
                    Console.Write(coordinate + " ");
                }
                else if (coordinate > 9)
                {
                    Console.Write(coordinate);
                }


                for (int w = 0; w < map.GetLength(0); w++)

                {

                    if (map[h, w] == m1)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.DarkGray;

                    }
                    else if (map[h, w] == r1)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    else if (map[h, w] == b1)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (map[h, w] == t1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.Green;

                    }
                    else if (map[h, w] == s1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Gray;

                    }
                    else if (map[h, w] == f1)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                    }
                    else if (map[h, w] == s1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Gray;

                    }
                    else if (map[h, w] == l1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Yellow;

                    }
                    else if (map[h, w] == rB)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else if (map[h, w] == w1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else if (map[h, w] == k1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else if (map[h, w] == p1)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else if (map[h, w] == nO)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write(map[h, w] + " ");


                }
                coordinate++;
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

 
}
