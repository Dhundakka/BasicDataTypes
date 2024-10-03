using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    internal class BreakStatement
    {
        static void Main()
        {
            int sum = 0;
            while (true)
            {

                Console.WriteLine("Enter a Number1:");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine(" Enter a Number2 :");
                int number2 = int.Parse(Console.ReadLine());


                if (number1 < 0 && number2 < 0)
                {
                    Console.WriteLine(" Sorry you Entered negative number");
                    break;
                    //Console.WriteLine(" Sorry you Entered negative number");
                }
                sum = number1 + number2;

                Console.WriteLine(" The sum of positive number is :" + sum);
            }
        }
    
    }
}

