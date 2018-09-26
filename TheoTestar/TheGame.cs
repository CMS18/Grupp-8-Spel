using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoTestar
{

    class TheGame
    {
        public List<TheWorldBuilder> worldCreate { get; set; }
        TheWorldBuilder worldItem = new TheWorldBuilder();
        public bool isRunning = true;
        private bool _gameOver = false;
        public string currentPosition;
        public string currentDescription;

        public int lX = 1;
        public int lY = 12;


        // GÅ **************************** GÅ
        public string north = "north".ToUpper();
        public string south = "south".ToUpper();
        public string east = "east".ToUpper();
        public string west = "west".ToUpper();
        public string no = "n".ToUpper();
        public string so = "s".ToUpper();
        public string ea = "e".ToUpper();
        public string we = "w".ToUpper();
        //GÅ ***************************** GÅ

        public string look = "look".ToUpper();
        public string mapCheck = "map".ToUpper();
        public string player = "You";
        public string use = "use".ToUpper();
        public string inv = "inv".ToUpper();
        public string lookAt = "look at".ToUpper();
        public string command = null;

        //MapGraphics *********** MapGraphics
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
        //MapGraphics ************ MapGraphics

        //StandardDescriptions ****** StandardDescriptions
        public string field1 = "Grassy";
        public string mountain = "Rocky";
        public string forest = "Trees";
        public string lava = "Hot";
        public string river = "Wet";
        public string bridge = "Bridgey";
        public string dirt = "Dirt";
        public bool walk1;
        public int moveInt = 0;
        //StandardDescriptions ****** StandardDescriptions

        public string message = null;
        private static string[,] DescriptionMap(string field1, string mountain, string forest, string lava, string river, string bridge, string dirt)
        {
            TheWorldBuilder world = new TheWorldBuilder();

            string spaceShip = world.Room[0].Name + ":\n" + world.Room[0].Description;
            string outSideSpaceShip = world.Room[1].Name + ": \n" + world.Room[1].Description;
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

                {null,   outSideSpaceShip, forest, forest, river, null, null, lava, lava, null, mountain, forest, mountain,                 null},

                {null,   spaceShip, mountain, mountain, null, null, null, null, null, null, mountain, field1, mountain,              null,},


                {null,   null, null, null, null, null, null, null, null, null, null, null, null,                                  null, },
            };
        }

        private static char[,] mapArray(char m1, char r1, char b1, char f1, char s1, char rB, char w1, char k1, char l1, char t1)
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



        public void isWalkable()
        {
            char[,] map = mapArray(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1);
            if (map.GetValue(lY, lX).ToString() == m1.ToString() || map.GetValue(lY, lX).ToString() == r1.ToString() || map.GetValue(lY, lX).ToString() == w1.ToString() || map.GetValue(lY, lX).ToString() == l1.ToString())
            {
                walk1 = false;
                return;
            }
            else
            {
                walk1 = true;
                return;
            }
        }


        public void LookAt()
        {
            Console.Write("Which Item : ");
            string itemInput = Console.ReadLine().ToUpper();

            for (int i = 0; i < worldItem.items.Count; i++)
            {
                if (worldItem.items[i].Name.Equals(itemInput))
                {
                    Console.WriteLine(worldItem.items[i].Description);
                }
            }

        }

        public void ItemUseWith()
        {
            Console.Write("Which item : ");
            string itemInput = Console.ReadLine().ToUpper();

            //int i;
            //for (i = 0; i < worldItem.items.Count; i++)
            //{
            //    if (worldItem.items[i].Name.Equals(itemInput))
            //    {
            //        Console.WriteLine(worldItem.items[i].Description);
            //    }
            //}
            foreach (var item in worldItem.items)
            {
                Console.WriteLine("Innan : " + item.Name);
            }
            Console.Write("with : ");

            itemInput = Console.ReadLine().ToUpper();
            for (int j = 0; j < worldItem.items.Count; j++)
            {
                if (worldItem.items[j].Name.Equals(itemInput))
                {

                    worldItem.items[j].Usable = false;
                    worldItem.items[worldItem.items[j].CombinableItems].Usable = false;
                    worldItem.items[worldItem.items[j].ResultItem].Usable = true;
                    //worldItem.items[].Usable = true;
                    //worldItem.items.RemoveAt(worldItem.items[j].CombinableItems);
                    //worldItem.items.RemoveAt();


                }

            }
            foreach (var item in worldItem.items)
            {

            Console.WriteLine(item.Usable);
            }

        }


        public void doAction(string command)
        {

            {

                char[,] map = mapArray(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1);
                string[,] locDesc = DescriptionMap(field1, mountain, forest, lava, river, bridge, dirt);
                currentPosition = map[lY, lX].ToString();
                currentDescription = locDesc[lY, lX].ToString();

                //DesignMap(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1, p1, map);

                if (command == use || command == "U")
                {
                 ItemUseWith();
                    
                    

                }
                if (command == inv)
                {

                    foreach (var item in worldItem.items)
                    {
                        Console.WriteLine(item.Name);
                    }


                    Console.WriteLine("Which index do you want to check");
                    command = Console.ReadLine();

                    int index = int.Parse(command);

                    Console.WriteLine(worldItem.items[index].Name);
                    return;


                }
                if (command == mapCheck)
                {
                    Console.Clear();
                    map.SetValue(p1, lY, lX);

                    DesignMap(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1, p1, nO, map);
                    Console.WriteLine("This is your current position! \n");
                }
                if (command.ToUpper() == lookAt)
                {
                    LookAt();
                    return;
                }
                if (command.ToUpper() == look)
                {

                    Console.WriteLine();
                    Console.WriteLine(currentDescription);
                    return;
                }


                if (command == north || command == south || command == west || command == east || command == no || command == so || command == ea || command == we)
                {

                    Console.Clear();

                    if (command == north || command == no)

                    {

                        lY = lY - 1;
                        isWalkable();
                        if (walk1 == false)
                        {
                            map.SetValue(nO, lY, lX);
                            lY = lY + 1;
                            map.SetValue(p1, lY, lX);
                            DesignMap(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1, p1, nO, map);
                            Console.WriteLine("You can't go there");
                            return;
                        }
                        else if (walk1 == true)
                        {

                            map.SetValue(p1, lY, lX);
                            currentDescription = locDesc.GetValue(lY, lX).ToString();
                            DesignMap(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1, p1, nO, map);
                            Console.WriteLine("Here's your new location : " + currentDescription);
                            return;
                        }


                    }
                    if (command == south || command == so)
                    {
                        //Console.Clear();
                        lY = lY + 1;
                        isWalkable();
                        if (walk1 == false)
                        {

                            map.SetValue(nO, lY, lX);
                            lY = lY - 1;
                            map.SetValue(p1, lY, lX);
                            DesignMap(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1, p1, nO, map);
                            Console.WriteLine("You can't go there");
                            return;

                        }
                        else if (walk1 == true)
                        {

                            map.SetValue(p1, lY, lX);


                            currentDescription = locDesc.GetValue(lY, lX).ToString();
                            DesignMap(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1, p1, nO, map);
                            Console.WriteLine("Here's your new location : " + currentDescription);
                            return;
                        }

                    }

                    if (command == east || command == ea)
                    {
                        //Console.Clear();

                        lX = lX + 1;
                        isWalkable();
                        if (walk1 == false)
                        {

                            map.SetValue(nO, lY, lX);
                            currentDescription = locDesc.GetValue(lY, lX).ToString();
                            lX = lX - 1;
                            map.SetValue(p1, lY, lX);
                            DesignMap(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1, p1, nO, map);
                            Console.WriteLine("You can't go there" + currentDescription);
                            return;
                        }

                        else if (walk1 == true)
                        {
                            currentPosition = map.GetValue(lY, lX).ToString();
                            map.SetValue(p1, lY, lX);

                            currentDescription = locDesc.GetValue(lY, lX).ToString();
                            DesignMap(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1, p1, nO, map);
                            Console.WriteLine("Here's your new location : " + currentDescription);
                            return;
                        }


                    }
                    if (command == west || command == we)
                    {
                        //Console.Clear();

                        lX = lX - 1;
                        isWalkable();
                        if (walk1 == false)
                        {

                            map.SetValue(nO, lY, lX);
                            currentDescription = locDesc.GetValue(lY, lX).ToString();
                            lX = lX + 1;
                            map.SetValue(p1, lY, lX);
                            DesignMap(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1, p1, nO, map);
                            Console.WriteLine("You can't go there " + currentDescription);
                            return;
                        }
                        else if (walk1 == true)
                        {

                            map.SetValue(p1, lY, lX);

                            currentDescription = locDesc.GetValue(lY, lX).ToString();
                            DesignMap(m1, r1, b1, f1, s1, rB, w1, k1, l1, t1, p1, nO, map);
                            Console.WriteLine("Here's your new location : " + currentDescription);
                            return;
                        }


                    }

                }

                if (command == "move")
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

        public void Update()
        {
            string currentCommand = Console.ReadLine().ToUpper();

            // instantly check for a quit
            if (currentCommand == "quit" || currentCommand == "q")
            {
                isRunning = false;
                return;
            }


            if (!_gameOver)
            {
                // otherwise, process commands.
                doAction(currentCommand);
            }
            else
            {
                Console.WriteLine("\nNope. Time to quit.\n");
            }
        }
    }


}
