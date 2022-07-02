using System;

namespace Task_1_HW05.Movement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                const char toWrite = '*';
                int x = 0, y = 0;

                Write(toWrite);

                while (true)
                {
                    if (Console.KeyAvailable)
                    {
                        var command = Console.ReadKey().Key;

                        switch (command)
                        {
                            case ConsoleKey.W:
                                if (y > 0) 
                                {
                                    y--;
                                }
                                break;
                            case ConsoleKey.A:
                                if (x > 0)
                                {
                                    x--;
                                }
                                break;
                            case ConsoleKey.S:
                                y++;
                                break;
                            case ConsoleKey.D:
                                x++;
                                break;
                        }
                        
                        Write(toWrite, x, y);
                    }
                }
            }
        }

        private static void Write(char toWrite, int x = 0, int y = 0)
        {
            try
            {
                if (x >= 0 && y >= 0)
                    Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write(toWrite);
            }
            catch (Exception) { }
        }
    }
}

