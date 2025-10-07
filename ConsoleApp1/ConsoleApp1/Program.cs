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
             /*int a = 3; int b = 7;
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

             Console.WriteLine(text);*/
           
            double number1 = 0; double number2 = 0;
            
            string input = Console.ReadLine();
            number1 = double.Parse(input);
            
            input = Console.ReadLine();
            number2 = double.Parse(input);    
            
            Console.WriteLine(number1);
            Console.WriteLine(number2);

            if (number1 > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }

            /*Console.WriteLine(q + e);
            Console.WriteLine(q * e);
            Console.WriteLine(q - e);
            Console.WriteLine(q / e);   
            */
        }
    }
}
