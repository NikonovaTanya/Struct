using System;

namespace Color
{
    class Program
    {   static void colorText(string text, myColor color)
        { switch (color)
          {
                case myColor.yellow:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(text);
                        break;
                    }
                case myColor.red:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(text);
                        break;
                    }
                case myColor.blue:
                {  Console.ForegroundColor = ConsoleColor.Blue;
                   Console.WriteLine(text);
                   break;
                }
                case myColor.green:
                {  Console.ForegroundColor = ConsoleColor.Green;
                   Console.WriteLine(text);
                   break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            Console.WriteLine("Введите цвет: 0 - yellow, 1 - red, 2 - blue, 3 - green");
            int c = int.Parse(Console.ReadLine());
            myColor cc = (myColor)c;
            colorText(str, cc);
        }
    }
}
  