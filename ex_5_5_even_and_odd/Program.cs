using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5_5_even_and_odd
{
    class Program
    {
        static void Main()
        {
            /*  5-5	Even and Odd? 
            The remainder operator (%) can be used to determine if a number is even or odd. 
            If you take a number and divide it by 2 and the remainder is 0, the number is even. 
            If the remainder is 1,the number is odd. 

            Write a program that asks the user for a number and displays whether the number is even or odd.
            */

            Console.WriteLine("Enter whole number and be told if it is Even or Odd:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is Even.");
            }
            else
            {
                Console.WriteLine("The number is Odd.");
            }
            Console.ReadKey();

        }
    }
}
