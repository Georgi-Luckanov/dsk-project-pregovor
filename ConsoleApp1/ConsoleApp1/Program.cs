using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3; int b = 7;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);

            double c = 3.1415;
            Console.WriteLine(c + a);
            Console.WriteLine(c * a);

            string name = "pencho";
            Console.WriteLine(name);

            float d = 2.51f;

            // double + double
            Console.WriteLine(d + c);

            //float * int
            Console.WriteLine(d * 2);
            // float * (flaot)cast
            Console.WriteLine(d * (float)2);
            // float * float
            Console.WriteLine (d * 2f);

            float neshto = 5.1234f;

            //Example:
            int number = 5;
            
            String text = Console.ReadLine();
            
            Console.WriteLine(text);
        }
    }
}
