using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    internal class ControlStatement
    {
        static void Main()
        {
            Console.Write("Enter a Integer Value");
            //int number = int.parse(Console.ReadLine());

            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {

                Console.WriteLine("Number is Positive");
            }
            else if (number < 0)
            {

                Console.WriteLine("Number is Negative");
            }
            else
            {
                Console.WriteLine("Number is Zero");
            }
        }
    }
}

