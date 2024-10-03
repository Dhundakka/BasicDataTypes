using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    internal class GradeCalculation
    {
        static void Main()
        {
            Console.Write("Enter the Grade :");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 79 && grade <= 100)
            {
                Console.WriteLine(" Your Grade is A");

            }
            else if (grade >= 59 && grade <= 80)
            {
                Console.WriteLine(" Your grade is B");

            }
            else if (grade >= 39 && grade <= 60)
            {
                Console.WriteLine("Your grade is  C");

            }
            else if (grade >= 35)
            {
                Console.WriteLine(" Your Grade is D");
            }
            else
            {
                Console.WriteLine(" Your grade is F ");
            }
        }
    }
}
