using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
namespace ConsoleApplication56
{
    class Program
    {
        static int[,] up = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
        static int[,] left = { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } };
        static int[,] front = { { 3, 3, 3 }, { 3, 3, 3 }, { 3, 3, 3 } };
        static int[,] right = { { 4, 4, 4 }, { 4, 4, 4 }, { 4, 4, 4 } };
        static int[,] back = { { 5, 5, 5 }, { 5, 5, 5 }, { 5, 5, 5 } };
        static int[,] down = { { 6, 6, 6 }, { 6, 6, 6 }, { 6, 6, 6 } };
        static int count1 = 0;
        static int count2 = 0;
        static void Display()
        {
            //Console.WriteLine("                       UP      ");
            //Console.WriteLine("                 +---+---+---+          ");
            //Console.WriteLine("                 |   |   |   |          "+"  Command:"+ count1 );
            //Console.WriteLine("                 +---+---+---+          "+"Rotations:"+ count2 );
            //Console.WriteLine("                 |   |   |   |          ");
            //Console.WriteLine("                 +---+---+---+          ");
            //Console.WriteLine("                 |   |   |   |          ");
            //Console.WriteLine("       LEFT      +---+---+---+      RIGHT          BACK ");
            //Console.WriteLine("  +---+---+---+  +---+---+---+  +---+---+---+  +---+---+---+        ");
            //Console.WriteLine("  |   |   |   |  |   |   |   |  |   |   |   |  |   |   |   |         ");
            //Console.WriteLine("  +---+---+---+  +---+---+---+  +---+---+---+  +---+---+---+        ");
            //Console.WriteLine("  |   |   |   |  |   |   |   |  |   |   |   |  |   |   |   |         ");
            //Console.WriteLine("  +---+---+---+  +---+---+---+  +---+---+---+  +---+---+---+        ");
            //Console.WriteLine("  |   |   |   |  |   |   |   |  |   |   |   |  |   |   |   |         ");
            //Console.WriteLine("  +---+---+---+  +---+---+---+  +---+---+---+  +---+---+---+        ");
            //Console.WriteLine("                 +---+---+---+          ");
            //Console.WriteLine("                 |   |   |   |          ");
            //Console.WriteLine("                 +---+---+---+          ");
            //Console.WriteLine("                 |   |   |   |          ");
            //Console.WriteLine("                 +---+---+---+          ");
            //Console.WriteLine("                 |   |   |   |          ");
            //Console.WriteLine("                 +---+---+---+          ");
            //Console.WriteLine("                     DOWN               ");
            Console.ResetColor();

            Console.SetCursorPosition(0, 23);
            Console.WriteLine("Enter Command:");
            Console.SetCursorPosition(45, 23);
            Console.WriteLine("Command:"+ count2);
            Console.SetCursorPosition(43, 24);
            Console.WriteLine("Rotations:"+count1);
            
            // table position and coloring
            int x = 19;
            int y = 2;

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {

                    if (up[i, j] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (up[i, j] == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (up[i, j] == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (up[i, j] == 4)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (up[i, j] == 5)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (up[i, j] == 6)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    x = x + 4;
                }
                x = 19;
                y = y + 2;
            }


            x = 4;
            y = 9;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (left[i, j] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (left[i, j] == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (left[i, j] == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (left[i, j] == 4)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (left[i, j] == 5)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (left[i, j] == 6)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    x = x + 4;
                }

                x = 4;
                y = y + 2;
            }

            x = 19;
            y = 9;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (front[i, j] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (front[i, j] == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (front[i, j] == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (front[i, j] == 4)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (front[i, j] == 5)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (front[i, j] == 6)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    x = x + 4;
                }
                x = 19;
                y = y + 2;
            }
            x = 34;
            y = 9;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (right[i, j] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (right[i, j] == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (right[i, j] == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (right[i, j] == 4)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (right[i, j] == 5)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (right[i, j] == 6)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }

                    x = x + 4;
                }
                x = 34;
                y = y + 2;
            }
            x = 49;
            y = 9;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (back[i, j] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (back[i, j] == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (back[i, j] == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (back[i, j] == 4)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (back[i, j] == 5)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (back[i, j] == 6)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    x = x + 4;
                }
                x = 49;
                y = y + 2;
            }
            x = 19;
            y = 16;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (down[i, j] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (down[i, j] == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (down[i, j] == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (down[i, j] == 4)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (down[i, j] == 5)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    else if (down[i, j] == 6)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.SetCursorPosition(x - 1, y);
                        Console.Write("   ");
                    }
                    x = x + 4;
                }
                x = 19;
                y = y + 2;
            }
            Console.SetCursorPosition(14, 23);

        }


        static void Rotfront(int numbers) // front move
        {
            for (int i = 0; i < numbers; i++)
            {
                int temp = right[0, 0];
                int temp1 = right[1, 0];
                int temp2 = right[2, 0];

                right[0, 0] = up[2, 0];
                right[1, 0] = up[2, 1];
                right[2, 0] = up[2, 2];

                up[2, 0] = left[0, 2];
                up[2, 1] = left[1, 2];
                up[2, 2] = left[2, 2];

                left[2, 2] = down[0, 2];
                left[1, 2] = down[0, 1];
                left[0, 2] = down[0, 0];

                down[0, 2] = temp;
                down[0, 1] = temp1;
                down[0, 0] = temp2;




            }


        }
        static void Rotup(int numbers)
        {
            for (int i = 0; i < numbers; i++)
            {
                int temp = left[0, 0];
                int temp1 = left[0, 1];
                int temp2 = left[0, 2];

                left[0, 0] = front[0, 0];
                left[0, 1] = front[0, 1];
                left[0, 2] = front[0, 2];

                front[0, 0] = right[0, 0];
                front[0, 1] = right[0, 1];
                front[0, 2] = right[0, 2];


                right[0, 0] = back[0, 0];
                right[0, 1] = back[0, 1];
                right[0, 2] = back[0, 2];


                back[0, 2] = temp2;
                back[0, 0] = temp;
                back[0, 1] = temp1;




            }
        } // up move

        static void Rotleft(int numbers)
        {
            for (int i = 0; i < numbers; i++)
            {
                int temp = up[2, 0];
                int temp1 = up[1, 0];
                int temp2 = up[0, 0];

                up[2, 0] = front[2, 0];
                up[1, 0] = front[1, 0];
                up[0, 0] = front[0, 0];

                front[0, 0] = down[0, 0];
                front[1, 0] = down[1, 0];
                front[2, 0] = down[2, 0];

                down[0, 0] = back[0, 2];
                down[1, 0] = back[1, 2];
                down[2, 0] = back[2, 2];

                back[0, 2] = temp;
                back[1, 2] = temp1;
                back[2, 2] = temp2;


            }
        } // left move

        static void Rotright(int numbers)
        {
            for (int i = 0; i < numbers; i++)
            {
                int temp = up[0, 2];
                int temp1 = up[1, 2];
                int temp2 = up[2, 2];

                up[0, 2] = front[0, 2];
                up[1, 2] = front[1, 2];
                up[2, 2] = front[2, 2];

                front[0, 2] = down[0, 2];
                front[1, 2] = down[1, 2];
                front[2, 2] = down[2, 2];

                down[0, 2] = back[2, 0];
                down[1, 2] = back[1, 0];
                down[2, 2] = back[0, 0];

                back[2, 0] = temp;
                back[1, 0] = temp1;
                back[0, 0] = temp2;


            }
        } // right move

        static void Rotback(int numbers)
        {
            for (int i = 0; i < numbers; i++)
            {
                int temp = down[2, 0];
                int temp1 = down[2, 1];
                int temp2 = down[2, 2];

                down[2, 0] = left[0, 0];
                down[2, 1] = left[1, 0];
                down[2, 2] = left[2, 0];

                left[0, 0] = up[0, 2];
                left[1, 0] = up[1, 0];
                left[2, 0] = up[0, 0];

                up[0, 2] = right[2, 2];
                up[0, 1] = right[1, 2];
                up[0, 0] = right[0, 2];

                right[2, 2] = temp;
                right[1, 2] = temp1;
                right[0, 2] = temp2;
            }

        } // back move

        static void Rotdown(int numbers)
        {
            for (int i = 0; i < numbers; i++)
            {
                int temp = right[0, 0];
                int temp1 = right[1, 0];
                int temp2 = right[2, 0];

                right[2, 0] = front[2, 0];
                right[2, 1] = front[2, 1];
                right[2, 2] = front[2, 2];

                front[2, 0] = left[2, 2];
                front[2, 1] = left[2, 1];
                front[2, 2] = left[2, 0];

                left[2, 2] = back[2, 0];
                left[2, 1] = back[2, 1];
                left[2, 0] = back[2, 2];


                back[2, 0] = temp;
                back[2, 1] = temp1;
                back[2, 2] = temp2;

            }

        } // down move
        static void Shuffle(int numbers) 
        {
            Random rnd = new Random();

            for (int i = 0; i < numbers; i++)
            {
                int shfl = rnd.Next(0, 6);
                int numb = rnd.Next(1, 4);
                if (shfl == 0)
                {
                    Rotfront(numb);
                }
                else if (shfl == 1)
                {
                    Rotup(numb);
                }
                else if (shfl == 2)
                {
                    Rotleft(numb);

                }
                else if (shfl == 3)
                {
                    Rotright(numb);


                }
                else if (shfl == 4)
                {
                    Rotback(numb);

                }
                else if (shfl == 5)
                {
                    Rotdown(numb);

                }

            }

            Display();


        } // shuffle 
        static bool Finish()
        {
            bool flag = true;
            int controlTemp = up[1, 1];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (up[i, j] != controlTemp)
                    {
                        flag = false;
                        break;
                    }

                }

                if (!flag)
                    break;

            }

            if (flag)
            {
                 controlTemp = down[1, 1];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (down[i, j] != controlTemp)
                        {
                            flag = false;
                            break;
                        }

                    }

                    if (!flag)
                        break;

                }
             
            }
            if (flag)
            {
                controlTemp = left[1, 1];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (left[i, j] != controlTemp)
                        {
                            flag = false;
                            break;
                        }

                    }

                    if (!flag)
                        break;

                }

            }
            if (flag)
            {
                controlTemp = right[1, 1];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (right[i, j] != controlTemp)
                        {
                            flag = false;
                            break;
                        }

                    }

                    if (!flag)
                        break;

                }

            }
            if (flag)
            {
                controlTemp = front[1, 1];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (front[i, j] != controlTemp)
                        {
                            flag = false;
                            break;
                        }

                    }

                    if (!flag)
                        break;

                }

            }
            if (flag)
            {
                controlTemp = back[1, 1];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (back[i, j] != controlTemp)
                        {
                            flag = false;
                            break;
                        }

                    }

                    if (!flag)
                        break;

                }

            }
            return flag;
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

           
            Console.Title = "";



            SoundPlayer player = new SoundPlayer();
            string path = "1.wav"; // file place
            player.SoundLocation = path;
            player.Play(); //play it

            for (int i = 1; i < 75; i++)
            {
                Console.SetWindowSize(i, 15);
                System.Threading.Thread.Sleep(50);
            }


            bool a = true;
            int count = 0;
            string yazi = "................................................................................";
            string kayan_yazi = "  " + (char)15 + (char)15 + (char)15 + "  " + (char)15 + (char)15 + (char)15 + "  " + (char)15 + " " + (char)15 + "  " + (char)15 + (char)15 + (char)15 + "  " + (char)15 + "  " + (char)15 + " " + (char)15 + "  " + (char)15 + (char)15 + (char)15 + "              " + (char)15 + (char)15 + (char)15 + "................................................................................";
            string kayan_yazi1 = " " + (char)15 + (char)15 + (char)15 + (char)15 + "  " + (char)15 + " " + (char)15 + "  " + (char)15 + " " + (char)15 + "  " + (char)15 + " " + (char)15 + "  " + (char)15 + "  " + (char)15 + (char)15 + "   " + (char)15 + "               " + (char)15 + (char)15 + (char)15 + (char)15 + "................................................................................";
            string kayan_yazi2 = "" + (char)15 + (char)15 + (char)15 + (char)15 + (char)15 + "  " + (char)15 + (char)15 + (char)15 + "  " + (char)15 + " " + (char)15 + "  " + (char)15 + (char)15 + (char)15 + "  " + (char)15 + "  " + (char)15 + (char)15 + "   " + (char)15 + (char)15 + (char)15 + "            " + (char)15 + (char)15 + (char)15 + (char)15 + (char)15 + "................................................................................";
            string kayan_yazi3 = "" + (char)15 + (char)15 + (char)15 + (char)15 + "   " + (char)15 + " " + (char)15 + "  " + (char)15 + " " + (char)15 + "  " + (char)15 + " " + (char)15 + "  " + (char)15 + "  " + (char)15 + " " + (char)15 + "    " + (char)15 + "            " + (char)15 + (char)15 + (char)15 + (char)15 + " " + "................................................................................";
            string kayan_yazi4 = "" + (char)15 + (char)15 + (char)15 + "    " + (char)15 + " " + (char)15 + "  " + (char)15 + (char)15 + (char)15 + "  " + (char)15 + (char)15 + (char)15 + "  " + (char)15 + "  " + (char)15 + " " + (char)15 + "  " + (char)15 + (char)15 + (char)15 + "            " + (char)15 + (char)15 + (char)15 + "  " + "................................................................................";
            string kayan_yazi5 = ".................................................................................................";
            string kayan_yazi6 = "..................................................................................................";
            string kayan_yazi7 = "........................." + (char)15 + (char)15 + (char)15 + "  " + (char)15 + " " + (char)15 + "  " + (char)15 + (char)15 + (char)15 + "  " + (char)15 + (char)15 + (char)15 + "................................................................................";
            string kayan_yazi8 = "........................." + (char)15 + "    " + (char)15 + " " + (char)15 + "  " + (char)15 + " " + (char)15 + "  " + (char)15 + "  " + "................................................................................";
            string kayan_yazi9 = "........................." + (char)15 + "    " + (char)15 + " " + (char)15 + "  " + (char)15 + (char)15 + (char)15 + "  " + (char)15 + (char)15 + (char)15 + "................................................................................";
            string kayan_yazi10 = "........................." + (char)15 + "    " + (char)15 + " " + (char)15 + "  " + (char)15 + " " + (char)15 + "  " + (char)15 + "  " + "................................................................................";
            string kayan_yazi11 = "........................." + (char)15 + (char)15 + (char)15 + "  " + (char)15 + (char)15 + (char)15 + "  " + (char)15 + (char)15 + (char)15 + "  " + (char)15 + (char)15 + (char)15 + "................................................................................";
            while (a)
            {
                Thread.Sleep(100);

                Console.SetCursorPosition(0, 0);
                yazi = yazi.Substring(1) + yazi.Substring(0, 1);
                kayan_yazi = kayan_yazi.Substring(1) + kayan_yazi.Substring(0, 1);
                kayan_yazi1 = kayan_yazi1.Substring(1) + kayan_yazi1.Substring(0, 1);
                kayan_yazi2 = kayan_yazi2.Substring(1) + kayan_yazi2.Substring(0, 1);
                kayan_yazi3 = kayan_yazi3.Substring(1) + kayan_yazi3.Substring(0, 1);
                kayan_yazi4 = kayan_yazi4.Substring(1) + kayan_yazi4.Substring(0, 1);
                kayan_yazi5 = kayan_yazi5.Substring(1) + kayan_yazi5.Substring(0, 1);
                kayan_yazi6 = kayan_yazi6.Substring(1) + kayan_yazi6.Substring(0, 1);
                kayan_yazi7 = kayan_yazi7.Substring(1) + kayan_yazi7.Substring(0, 1);
                kayan_yazi8 = kayan_yazi8.Substring(1) + kayan_yazi8.Substring(0, 1);
                kayan_yazi9 = kayan_yazi9.Substring(1) + kayan_yazi9.Substring(0, 1);
                kayan_yazi10 = kayan_yazi10.Substring(1) + kayan_yazi10.Substring(0, 1);
                kayan_yazi11 = kayan_yazi11.Substring(1) + kayan_yazi11.Substring(0, 1);
                Console.WriteLine(yazi);

                Console.SetCursorPosition(0, 1);

                Console.WriteLine(kayan_yazi.Substring(6) + kayan_yazi.Substring(5, 1));

                Console.SetCursorPosition(0, 2);

                Console.WriteLine(kayan_yazi1.Substring(6) + kayan_yazi1.Substring(10, 1));

                Console.SetCursorPosition(0, 3);

                Console.WriteLine(kayan_yazi2.Substring(6) + kayan_yazi2.Substring(15, 1));

                Console.SetCursorPosition(0, 4);

                Console.WriteLine(kayan_yazi3.Substring(6) + kayan_yazi3.Substring(20, 1));

                Console.SetCursorPosition(0, 5);

                Console.WriteLine(kayan_yazi4.Substring(6) + kayan_yazi4.Substring(29, 1));

                Console.SetCursorPosition(0, 6);

                Console.WriteLine(kayan_yazi5.Substring(6) + kayan_yazi5.Substring(0, 1));

                Console.SetCursorPosition(0, 7);

                Console.WriteLine(kayan_yazi6.Substring(6) + kayan_yazi6.Substring(32, 1));
                Console.SetCursorPosition(0, 8);

                Console.WriteLine(kayan_yazi7.Substring(6) + kayan_yazi7.Substring(32, 1));
                Console.SetCursorPosition(0, 9);



                Console.WriteLine(kayan_yazi8.Substring(6) + kayan_yazi8.Substring(32, 1));
                Console.SetCursorPosition(0, 10);

                Console.WriteLine(kayan_yazi9.Substring(6) + kayan_yazi9.Substring(32, 1));
                Console.SetCursorPosition(0, 11);

                Console.WriteLine(kayan_yazi10.Substring(6) + kayan_yazi10.Substring(32, 1));
                Console.SetCursorPosition(0, 12);


                Console.WriteLine(kayan_yazi11.Substring(6) + kayan_yazi11.Substring(32, 1));
                Console.SetCursorPosition(0, 13);



                Console.WriteLine(yazi);


                count++;

                if (count == 110)
                    a = false;

                else

                    a = true;


            } // slider

            for (int i = 15; i < 30; i++)
            {
                Console.SetWindowSize(75, i);
                System.Threading.Thread.Sleep(50);
            }
            int options = 0;
            bool cycle = true;
            while (cycle)
            {

                Console.SetCursorPosition(0, 15);
                Console.WriteLine("Options");
                Console.WriteLine("1-Play Game");
                Console.WriteLine("2-About the Game");
                Console.WriteLine("3-Quit");

                options = Convert.ToInt32(Console.ReadLine());

                if (options != 1 || options != 2 || options != 3)
                {
                    cycle = false;
                }
            }
            Console.Clear();
            switch (options)
            {

                case 1:
                    
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();

                    

                    Shuffle(30);

                    for (int i = 75; i < 85; i++)
                    {
                        Console.SetWindowSize(i, 30);
                        System.Threading.Thread.Sleep(50);
                    }

                    string Progresbar = "Rubic`s Cube";
                    var title = "";

                    for (int i = 0; i < Progresbar.Length; i++)
                    {
                        title += Progresbar[i];
                        Console.Title = title;
                        System.Threading.Thread.Sleep(50);
                    }
                    title = "";



                   // Display();
                    Console.ResetColor();

                    bool flag = false;
                    while (!flag)
                    {

                        count2++; 
                        Console.ResetColor();
                        string command = Console.ReadLine();
                        command = command.ToUpper();
                        int start = 1;
                        for (int i = 0; i < command.Length; i++)
                        {

                               

                            if (Convert.ToChar(command.Substring(i, 1)) >= 65 && Convert.ToChar(command.Substring(i, 1)) <= 90)
                            {
                                
                                string cmd = command.Substring(i, 2);
                                start = i;
                                if (!(cmd.Contains('1') || cmd.Contains('2') || cmd.Contains('3') || cmd.Contains('4') || cmd.Contains('5') || cmd.Contains('6') || cmd.Contains('7') || cmd.Contains('8') || cmd.Contains('9') || cmd.Contains('0')))
                                {
                                    Console.WriteLine("wrong input");
                                    break;
                                }
                                
                                {
                                    int numbers = Convert.ToInt16(cmd.Substring(1));
                                    numbers = numbers % 4;
                                    if (cmd.Substring(0, 1) == "F")
                                    {
                                        Rotfront(numbers);

                                    }
                                    else if (cmd.Substring(0, 1) == "D")
                                    {
                                        Rotdown(numbers);
                                    }
                                    else if (cmd.Substring(0, 1) == "B")
                                    {
                                        Rotback(numbers);
                                    }
                                    else if (cmd.Substring(0, 1) == "R")
                                    {
                                        Rotright(numbers);
                                    }
                                    else if (cmd.Substring(0, 1) == "L")
                                    {
                                        Rotleft(numbers);
                                    }
                                    else if (cmd.Substring(0, 1) == "U")
                                    {
                                        Rotup(numbers);
                                    }

                                    

                                    count1++;
                                    Display();
                                    flag = Finish();

                                    
                                    if (flag)
                                        break;
                                }
                            }
                        }

                        
                        
                        if (flag)
                        {
                            Console.WriteLine("Winnnig");
                        }

                        Console.ResetColor();
                        Console.SetCursorPosition(14, 23);
                        Console.Write("              ");
                    
                        Console.SetCursorPosition(14, 23);
                    }
                    
                    break;
                case 2: // about the game
                    Console.WriteLine("Code/Project : CME1101/3");
                    Console.WriteLine("Year/Semester: 2014/2015 Fall Semester");
                    Console.WriteLine("Duration : 5 weeks");
                    Console.WriteLine(" ");
                    Console.WriteLine("Project: Rubik`s Cube");
                    Console.WriteLine("The aim of the project is to develop a single-player Rubik`s Cube puzzle game.");
                    Console.WriteLine(" ");

                    Console.WriteLine("Game Playing Rules");
                    Console.WriteLine("1. The game is played on a cube(3*3*3) ");
                    Console.WriteLine("2. The player`s objective is to solve (to convert to inital state) the cube by rotating its 6 faces.");
                    Console.WriteLine("3. Eachface is repsent as a single caracter. Up is represented by U; Front is represented by F and so ");
                    Console.WriteLine("on... So we have abbreviations representing all faces of the cube as {U,D,R,L,F,B} ");
                    Console.WriteLine("4.Possible operations of the cube are rotating its faces clockwise.");
                    Console.WriteLine(" ");

                    Console.WriteLine("How To Play");
                    Console.WriteLine("In each round a sequence of rotations is entered to game such as R2B1U4 this command means: Rotate");
                    Console.WriteLine("the cube`s Right face 2 times, then 1 time Bottom and then 4 times Up.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Developers:");
                    Console.WriteLine("2013510009 | HATİCE NUR ALPTEKİN");
                    Console.WriteLine("2014510080 | BÜŞRA ŞAFAK ZIRHLI");
                    Console.WriteLine("2013510044 | REYHAN GÜNAYDIN");
                    Console.WriteLine("2012510017 | MUSTAFA KAAN DEMİRHAN");

                    Console.WriteLine(" ");
                    Console.WriteLine("Web Side");
                    Console.WriteLine("http://rubicscube.comoj.com/");

                    
                    break;
                case 3: // quit optios
                    Console.WriteLine("system closing...");

            int hour = System.DateTime.Now.Hour;
            for (int i = 0; i <= 65; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("▓");
                Thread.Sleep(52);
                if (i>=42)
                    Thread.Sleep(70);

                
            }
            Console.WriteLine(" ");
            if (hour <= 12 && hour >= 6) 
            Console.WriteLine("Good Morning...");
            else if(hour>12 && hour<=18 )
                Console.WriteLine("Good Evening...");
            else 
                Console.WriteLine("Good Night...");
            Thread.Sleep(300);
            Environment.Exit(0);
            
                    break;

            }

            Console.ReadLine();

        }

    }

}