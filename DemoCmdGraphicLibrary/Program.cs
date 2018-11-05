using System;
using System.Collections.Generic;
using CmdGraphicLibrary;

namespace DemoCmdGraphicLibrary
{
    struct Cords
    {
        public int x;
        public int y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            CmdGraphic x = new CmdGraphic(20, 40);
            int cursorx = 10, cursory = 10;
            Console.CursorVisible = false;
            List<Cords> chars = new List<Cords>();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);//true don't print char on console
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            cursory--;
                            break;
                        case ConsoleKey.DownArrow:
                            cursory++;
                            break;
                        case ConsoleKey.RightArrow:
                            cursorx++;
                            break;
                        case ConsoleKey.LeftArrow:
                            cursorx--;
                            break;
                        case ConsoleKey.Spacebar:
                            chars.Add(new Cords(){x = cursorx, y = cursory});
                            break;
                        default:
                            break;
                    }
                }

                //x.Fill(' ');

                foreach (var cords in chars)
                {
                      x.DrawCharAt(cords.x, cords.y, '*');  
                }

                x.DrawCharAt(cursorx, cursory, '^');
                x.DrawTextHorizontally(0, 0, "X: " + cursorx + " Y:" + cursory);

                Console.SetCursorPosition(0, 0);
                Console.Write(x.GetBuffer());
            }
        }
    }
}
