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

            /*double number1 = 0; double number2 = 0;
            
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
            */
            /*Console.WriteLine(q + e);
            Console.WriteLine(q * e);
            Console.WriteLine(q - e);
            Console.WriteLine(q / e);   
            */

            //REVIEW TASKS//
            /* string reviewtasks = Console.ReadLine();
             double num = double.Parse(reviewtasks);
             Console.WriteLine(num);


             string reviewtasks2 = Console.ReadLine();
             double number = double.Parse(reviewtasks2);
             Console.WriteLine(number);
             Console.ReadLine();*/

            string data = Console.ReadLine();
            double num = double.Parse(data);

            //string data2 = Console.ReadLine();
            //double num2 = double.Parse(data2); (tova i dolnota vurshat edna i sushta rabota)
            data = Console.ReadLine();
            double num2 = double.Parse(data);

            Console.WriteLine("sum: " + (num + num2));
            Console.WriteLine("sum: " + (num - num2));
            Console.WriteLine("sum: " + (num * num2));

            if (num2 == 0)
            {
                ConsoleApp1.WriteLine("Cannot divide by zero");
            }
            else
            {
                ConsoleApp1.WriteLine("sum: " + (num / num2));
                ConsoleApp1.WriteLine("sum: " + (num % num2));
            }
            ConsoleApp1.WriteLine("Concatenation: " + num + num2);


            /*Console.WriteLine(data + data2);
            Console.WriteLine(data - data2);
            Console.WriteLine(data * data2);  kak bachka (text1) + (text2) = (text1)(text2)
            Console.WriteLine(data / data2);
            Console.WriteLine(data % data2);*/


            //day 5 review task2
            ConsoleApp1.WriteLine("\n\nDay 5 - Review tasks part 2\n\);
            double a;
            Cosnole.WriteLine("Rectangke side");
            string input = Console.ReadLine();
            double.Parse(input);
            double input = parse(a);
            double b ];
            Console.WriteLine("Reactangle");
            input = ConsoleApp1.ReadLine();
            
        }
    }
}