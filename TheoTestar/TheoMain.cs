using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoTestar
{
    class TheoMain
    {
        private string _currDesc;

        static void Main(string[] args)
        {
            int lX = 8;
            int lY = 5;

            string north = "north".ToUpper();
            string south = "south".ToUpper();
            string east = "east".ToUpper();
            string west = "west".ToUpper();
            string look = "look".ToUpper();
            string mapCheck = "map".ToUpper();
            string player = "You";

            string currentPosition;
            string currentDescription;
            bool quit = false;
            string userCommand = null;
            char m1 = '^';
            char r1 = '~';
            char b1 = '=';
            char f1 = '"';
            char s1 = '¨';
            char rB = '-';
            char w1 = '|';
            char k1 = '+';
            char l1 = '¤';
            char t1 = '*';
            char p1 = '!';// Gör en player vit som uppdateras på map
            string field1 = "Grassy";
            string mountain = "Rocky";
            string forest = "Trees";
            string lava = "Hot";
            string river = "Wet";
            string bridge = "Bridgey";
            string dirt = "Dirt";
            char[,] map = mapArray(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1);
            string message = null;
            designMap(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1, p1, map);
            string[,] locDesc = DescriptionMap(field1, mountain, forest, lava, river, bridge, dirt);
            loopDescriptionArray(message, locDesc);
            //De här ska bli description metod



            Console.WriteLine(message);



            currentPosition = map[lY, lX].ToString();
            currentDescription = locDesc[lY, lX].ToString();
            

            userCommand = Console.ReadLine();
            while (userCommand != "quit")
            {
                

                if (userCommand.ToUpper() == mapCheck)
                {
                    Console.Clear();
                    map.SetValue(p1, lY, lX);

                    designMap(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1, p1, map);
                    Console.WriteLine("This is your current position! \n");
                }

                if (userCommand.ToUpper() == look)
                {
                    Console.WriteLine("This is your current position: " + currentPosition);
                    Console.WriteLine("Description :" + currentDescription);
                }
                if (userCommand.ToUpper() == north)

                {
                    Console.Clear();
                    lY = lY - 1;
                    if (map.GetValue(lY, lX).ToString() == m1.ToString() || map.GetValue(lY, lX).ToString() == r1.ToString() || map.GetValue(lY, lX).ToString() == w1.ToString())
                    {
                        Console.WriteLine("You can't go there");
                        lY = lY + 1;
                    }
                    else if (map.GetValue(lY, lX).ToString() == f1.ToString() || map.GetValue(lY, lX).ToString() == t1.ToString() || map.GetValue(lY, lX).ToString() == b1.ToString() || map.GetValue(lY, lX).ToString() == s1.ToString())
                    {
                        currentPosition = map.GetValue(lY, lX).ToString();
                        map.SetValue(p1, lY, lX);
                        
                        currentDescription = locDesc.GetValue(lY, lX).ToString();
                        designMap(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1, p1, map);
                        Console.WriteLine("Here's your new location : " + currentPosition + " " + currentDescription);
                    }

                }
                else if (userCommand.ToUpper() == south)

                {
                    Console.Clear();
                    lY = lY + 1;
                    if (map.GetValue(lY, lX).ToString() == m1.ToString() || map.GetValue(lY, lX).ToString() == r1.ToString() || map.GetValue(lY, lX).ToString() == w1.ToString())
                    {
                        Console.WriteLine("You can't go there");
                        lY = lY - 1;
                    }
                    else if (map.GetValue(lY, lX).ToString() == f1.ToString() || map.GetValue(lY, lX).ToString() == t1.ToString() || map.GetValue(lY, lX).ToString() == b1.ToString() || map.GetValue(lY, lX).ToString() == s1.ToString())
                    {
                        currentPosition = map.GetValue(lY, lX).ToString();
                        map.SetValue(p1, lY, lX);
                        
                        currentDescription = locDesc.GetValue(lY, lX).ToString();
                        designMap(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1, p1, map);
                        Console.WriteLine("Here's your new location : " + currentPosition + " " + currentDescription);
                    }

                }
                else if (userCommand.ToUpper() == east)
                {
                    Console.Clear();

                    lX = lX + 1;
                    if (map.GetValue(lY, lX).ToString() == m1.ToString() || map.GetValue(lY, lX).ToString() == r1.ToString() || map.GetValue(lY, lX).ToString() == w1.ToString())
                    {
                        Console.WriteLine("You can't go there");
                        lX = lX - 1;
                    }
                    else if (map.GetValue(lY, lX).ToString() == f1.ToString() || map.GetValue(lY, lX).ToString() == t1.ToString() || map.GetValue(lY, lX).ToString() == b1.ToString() || map.GetValue(lY, lX).ToString() == s1.ToString())
                    {
                        currentPosition = map.GetValue(lY, lX).ToString();
                        map.SetValue(p1, lY, lX);
                        
                        currentDescription = locDesc.GetValue(lY, lX).ToString();                        
                        designMap(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1, p1, map);
                        Console.WriteLine("Here's your new location : " + currentPosition + " " + currentDescription);
                    }


                }
                else if (userCommand.ToUpper() == west)
                {
                    Console.Clear();

                    lX = lX - 1;
                    if (map.GetValue(lY, lX).ToString() == m1.ToString() || map.GetValue(lY, lX).ToString() == r1.ToString() || map.GetValue(lY, lX).ToString() == w1.ToString())
                    {
                        Console.WriteLine("You can't go there");
                        lX = lX + 1;
                    }
                    else if (map.GetValue(lY, lX).ToString() == f1.ToString() || map.GetValue(lY, lX).ToString() == t1.ToString() || map.GetValue(lY, lX).ToString() == b1.ToString() || map.GetValue(lY, lX).ToString() == s1.ToString())
                    {
                        currentPosition = map.GetValue(lY, lX).ToString();
                        map.SetValue(p1, lY, lX);
                        
                        currentDescription = locDesc.GetValue(lY, lX).ToString();
                        designMap(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1, p1, map);
                        Console.WriteLine("Here's your new location : " + currentPosition + " " + currentDescription);
                    }


                }
                if (userCommand == "move")
                {
                    int index1 = 0;
                    int index2 = 0;

                    string indexCurrent;



                    Console.WriteLine("What index do you want to check");
                    Console.Write("index1: ");
                    index1 = int.Parse(Console.ReadLine());
                    Console.Write("index2: ");
                    index2 = int.Parse(Console.ReadLine());
                    indexCurrent = map.GetValue(index1, index2).ToString();
                    if (indexCurrent == m1.ToString())
                    {
                        Console.WriteLine("A big mountains looms ahead of you, it seems do dangerous to climb!");
                    }
                    else if (indexCurrent == r1.ToString())
                    {
                        Console.WriteLine("The water appears to cold to swim in!");
                    }
                    else if (indexCurrent == l1.ToString())
                    {
                        Console.WriteLine("It's Lava");
                    }


                    Console.WriteLine("You moved");
                }
                Console.ReadKey();
            }

        }

      

        private static string[,] DescriptionMap(string field1, string mountain, string forest, string lava, string river, string bridge, string dirt)
        {
            return new string[14, 14]
            {
                {null, null, null, null, null, null, null, null, null, null, null, null, null,                                  null, },


                {null,   null, null, mountain, null, mountain, null, null, null, mountain, mountain, mountain, null,              null},

                {null,   null, mountain, field1, river, field1, mountain, null, mountain, field1, forest, forest, mountain,       null},

                {null,   mountain, field1, field1, bridge, field1, mountain, mountain, forest, forest, forest, forest ,mountain,  null},

                {null,   river, river, field1, river, field1 ,mountain, mountain, forest, field1, field1, field1, mountain,       null},

                {null,   field1, bridge, field1, river, field1, dirt, dirt, field1, field1, field1, field1, mountain,             null},

                {null,   field1, river, river, null, river, mountain, mountain, river, river, bridge, river, mountain,            null},

                {null,   field1, bridge, field1, river, null, null, null, null, mountain, dirt, dirt, mountain,                   null},

                {null,   river, river, field1, field1, mountain, null, null, lava, mountain, dirt, dirt, mountain,                null},

                {null,   river, forest, forest, field1, mountain, null, lava, dirt, dirt, dirt, dirt, mountain,                   null},

                {null,   forest, forest, forest, forest, mountain, lava, dirt, dirt, lava, mountain, forest, mountain,            null},

                {null,   forest, forest, forest, river, null, null, lava, lava, null, mountain, forest, mountain,                 null},

                {null,   forest, mountain, mountain, null, null, null, null, null, null, mountain, field1, mountain,              null,},


                {null,   null, null, null, null, null, null, null, null, null, null, null, null,                                  null, },
            };
        }

        private static char[,] mapArray(char m1, char r1, char b1, char f1, char s1, char rB, char w1, char k1, char l1, char t1)
        {
            return new char[14, 14]

      {
            {k1    ,rB, rB, rB, rB, rB, rB, rB, rB, rB, rB, rB, rB,     k1},

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

            {k1,    rB, rB, rB, rB, rB, rB, rB, rB, rB, rB, rB, rB,     k1},
      };
        }

        private static void loopDescriptionArray(string message, string[,] locDesc)
        {
            for (int h = 0; h < locDesc.GetLength(1); h++)
            {
                for (int w = 0; w < locDesc.GetLength(0); w++)
                {
                    message = locDesc[h, w];


                }
            }
        }

        private static void designMap(char m1, char r1, char b1, char f1, char s1, char rB, char w1, char k1, char l1, char t1, char p1, char[,] map)
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
