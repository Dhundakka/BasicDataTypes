using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    internal class SwitchStatement
    {
        static void Main()
        {
            Console.Write("*************Menu Card***************");
            Console.Write(" 1. Burger ");
            Console.Write(" 2. Pizza ");
            Console.Write(" 3. Salad ");
            Console.Write(" 4. Periferies ");
            Console.Write(" 5. Exit");

            Console.Write(" Enter Your Choice ");
            int menu = int.Parse(Console.ReadLine());
            

            switch (menu)
            {
                case 1:

                    Console.WriteLine(" You Choosen the menu Pizza " + " \nPrice = only @199/-");
                    break;
                 
                case 2:
                    Console.WriteLine(" You Choosen the menu Burger " + " \nPrice = Only @99 /-");
                    break;
                
                case 3:
                    Console.WriteLine(" You Choosen the menu salad " + " \nPrice = Only @199/-");
                    break;
                    
                case 4:
                    Console.WriteLine(" You Choosen the menu Periferies " + "\nPrice = Only @69/-");
                    break;
                default:
                    Console.WriteLine(" Your Choice is not available !!!!");
                    break ;

            }

        }
    }
}
