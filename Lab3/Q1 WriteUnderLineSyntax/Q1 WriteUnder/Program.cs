using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_WriteUnder
{
    class Program
    {
        public static void WriteUnder(string text)
        {
            int countSpaces = (80 - text.Length) / 2;
            int i = 0;

            for (; i < countSpaces; i++)
                Console.Write(" ");

            Console.WriteLine(text);

            for (i = 0; i < countSpaces; i++)
                Console.Write(" ");

            for (i = 0; i < text.Length; i++)
                Console.Write("_");
        }

        public static void WriteUnder1(string text) {
            int screenLength = 80 / 2;
            int Strlength = text.Length;
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < Strlength-1; i++)
            {
                s.Append('_');
            }
            string underlineKeyWord = s.ToString();
            for (int i = 0; i < screenLength; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("text");
        
            for (int i = 0; i < screenLength; i++)
            {
                Console.Write(" ");
            }
            Console.Write(underlineKeyWord);

        }
        static void Main(string[] args)
        {
            WriteUnder("Hello");
            //WriteUnder1("Hello");
            Console.ReadKey();
        }
    }
}
