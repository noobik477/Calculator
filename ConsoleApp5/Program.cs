using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            int str;
            int str2;

            Console.WriteLine("1 число: ");
            a = Console.ReadLine();
            str = Convert.ToInt32(a);

            Console.WriteLine("2 число: ");
            b = Console.ReadLine();
            str2 = Convert.ToInt32(b);

            double result = str + str2;
            Console.WriteLine("+ " + result);
            result = str * str2;
            Console.WriteLine("* " + result);
            result = str - str2;
            Console.WriteLine("- " + result);
            result = str / str2;
            Console.WriteLine("/ " + result);

            Console.ReadKey();
        }
    }
}
