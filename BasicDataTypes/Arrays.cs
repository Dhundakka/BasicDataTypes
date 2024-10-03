using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace BasicDataTypes
{
    internal class Arrays
    {
        public static void Main()
        {


            // Declare the array
            string[] mobile = new string[4];


            // Assigning values
            mobile[0] = "IPhone";
            mobile[1] = "Samsung";
            mobile[2] = "Realme";
            mobile[3] = "Redmi";

            // Access array values
            Console.WriteLine("Mobiles in array index");

            for (int i = 0; i < mobile.Length; i++)
            {
                Console.WriteLine(mobile[i]);

            }
            //reverese number
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            // Print original array
            Print(numbers);

            Reverse(numbers);


        }
        public static void Print(int[] arr)
        {
            foreach (var num in arr)
            {
                Console.WriteLine(num + " ");
            }
        }
            public static void Reverse(int[] arr)
            {
                int start = 0;
                int end = arr.Length - 1;

                while (start < end)
                {
                // Swaping
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
                }

            }
        }

    }
