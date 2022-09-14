//Девятая в списке (шрифт "Шаги лилипута")
using System;

namespace Font
{
    class Font
    {
        public static void Main()
        {
            string Chislo;
            Console.Write("Введите набор чисел: ");
            Chislo = Console.ReadLine();

            var SizeX = 6 * Chislo.Length;

            var x = (Console.WindowWidth / 2) - SizeX / 2;
            var y = (Console.WindowHeight / 2) - 2;
           
            foreach (char a in Chislo)
            {
                Console.SetCursorPosition(x, y);
                switch (a)
                {
                    case '0':
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ■■■");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("■   ■");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("■   ■");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("■   ■");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write(" ■■■");
                        break;

                    case '1':                       
                       Console.SetCursorPosition(x, y);
                        Console.Write("  ■");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write(" ■■");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("■ ■");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("  ■");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("■■■■■");
                        break;

                    case '2':                       
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ■■■");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("■   ■");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("  ■■");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write(" ■");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("■■■■■");
                        break;

                    case '3':                        
                        Console.SetCursorPosition(x, y);
                        Console.Write("■■■■");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("    ■");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write(" ■■■ ");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("    ■");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("■■■■");
                        break;

                    case '4':                      
                        Console.SetCursorPosition(x, y);
                        Console.Write("   ■");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("  ■■");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write(" ■ ■");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("■■■■■");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("   ■");
                        break;

                    case '5':    
                        Console.SetCursorPosition(x, y);
                        Console.Write("■■■■■");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("■");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("■■■■ ");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("    ■");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("■■■■ ");
                        break;

                    case '6':                      
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ■■■");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("■");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("■■■■");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("■   ■");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write(" ■■■");
                        break;

                    case '7':                      
                        Console.SetCursorPosition(x, y);
                        Console.Write("■■■■■");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("    ■");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("   ■");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("  ■");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("  ■");
                        break;

                    case '8':
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ■■■ ");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("■   ■");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write(" ■■■ ");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("■   ■");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write(" ■■■ ");
                        break;

                    case '9':
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ■■■ ");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("■   ■");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write(" ■■■■");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("    ■");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write(" ■■■ ");
                        break;

                    case '/':
                        Console.SetCursorPosition(x, y);
                        Console.Write("   ■ ");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("   ■ ");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("  ■ ");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write(" ■ ");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write(" ■");
                        break;

                    case ' ':
                        Console.SetCursorPosition(x, y);
                        Console.Write("     ");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("     ");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("     ");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("     ");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("     ");
                        break;
                }
                x += 7;
            }
        }
    }
}