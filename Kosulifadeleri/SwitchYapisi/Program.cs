using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor renk = Console.BackgroundColor;
            renk = ConsoleColor.DarkBlue;
            //if (renk == ConsoleColor.Black)
            //    Console.WriteLine("Siyah");
            //else if (renk == ConsoleColor.Red)
            //    Console.WriteLine("Kırmızı");
            //else
            //    Console.WriteLine("Bu rengi bilmiyorum.");

            switch (renk)
            {
                case ConsoleColor.Black:
                    Console.WriteLine("Siyah");
                    break;
                case ConsoleColor.DarkBlue:
                    Console.WriteLine("Koyu Mavi");
                    break;
                case ConsoleColor.DarkGreen:
                    Console.WriteLine("Koyu Yesil");
                    break;
                case ConsoleColor.DarkCyan:
                    Console.WriteLine("Koyu Cyan");
                    break;
                case ConsoleColor.DarkRed:
                    Console.WriteLine("Koyu Kırmızı");
                    break;
                case ConsoleColor.DarkMagenta:
                    Console.WriteLine("Koyu Magenta");
                    break;
                case ConsoleColor.DarkYellow:
                    break;
                case ConsoleColor.Gray:
                    break;
                case ConsoleColor.DarkGray:
                    break;
                case ConsoleColor.Blue:
                    break;
                case ConsoleColor.Green:
                    break;
                case ConsoleColor.Cyan:
                    break;
                case ConsoleColor.Red:
                    break;
                case ConsoleColor.Magenta:
                    break;
                case ConsoleColor.Yellow:
                    break;
                case ConsoleColor.White:
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
