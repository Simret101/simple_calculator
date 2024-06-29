using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            String ans;
            int result;
            Console.WriteLine("Welcome, Please Enter the first number.");
            num1 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Please Enter the Second number.");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the kind of operation you want to do."); 
            Console.WriteLine("        If it is addition enter + symbol, ");
            Console.WriteLine("        If it is subtraction enter - , ");
            Console.WriteLine("        If it is  enter * ,");
            Console.WriteLine("        If it is division enter / .");

            ans = Console.ReadLine();
            if (ans == "+") 
            {
                result = num1 + num2; 

            }
            else if (ans == "-")
            { 
                result = num1 - num2;
                
            }
            else if (ans == "*")
            { 
                result = num1 * num2;
                
            }
            else 
            { 
                result = num1 / num2;

                
            }
            Console.WriteLine($"The Answer is { result}");
            Console.WriteLine("Thank You for using Our Calculator!");
            Console.ReadLine();











        }
    }
}
