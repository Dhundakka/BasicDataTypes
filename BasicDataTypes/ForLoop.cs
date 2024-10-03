using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    internal class ForLoop
    {
        static void Main()
        {
            int num1 = 10;

            // For Loop
                Console.WriteLine(" For Loop----------------Number from 0 to 10 :");

                for (int i = 0; i<=num1;i++)
            { 
                Console.WriteLine(i);

            }
            int num2 = 10;
            int j = 0;
            //While Loop

            Console.WriteLine(" While Loop------------- Number From 0 to 10 :");
            while (j<=num2)
            {
                
                Console.WriteLine(j);    
                j++;
            }

            int num3 = 10;
            int k = 0;

            // Do While Loop
            Console.WriteLine(" While Loop------------- Number From 0 to 10 :");
            do
            {
                Console.WriteLine(k);
                k++;
            }
            while (k <= num3);


        }
    }
}
