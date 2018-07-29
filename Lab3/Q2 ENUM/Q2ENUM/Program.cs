using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2ENUM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Background Color Change Code
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();


            string[] name = Enum.GetNames(typeof(E_ColorEnum));
            Console.WriteLine("\t\t\t -------- Chose Color --------- ");
            foreach (var item in name)
            {
                Console.WriteLine(item + " => Value " + (int)Enum.Parse(typeof(E_ColorEnum), item));
            }

            while (true)
            {


                Console.WriteLine("\n Enter Integer Value");
                int value = Convert.ToInt32(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        Console.WriteLine("You Chose"+(E_ColorEnum)value);
                        break;
                    case 2:
                        Console.WriteLine("You Chose" + (E_ColorEnum)value);
                        break;
                    case 3:
                        Console.WriteLine("You Chose" + (E_ColorEnum)value);
                        break;
                    case 4:
                        Console.WriteLine("You Chose" + (E_ColorEnum)value);
                        break;
                    case 5:
                        Console.WriteLine("You Chose" + (E_ColorEnum)value);
                        break;
                        break;
                    default:
                        Console.WriteLine("Unexpected Input : Try Again");
                        continue;
                }
                Console.WriteLine();
                Console.WriteLine("\t\t\t---------  Program end   ------");
                break;
            }
            Console.ReadKey();
        }
    }
}
