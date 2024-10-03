using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    internal class ForEachLoop
    {
        static void Main() {
            string[] brand1 = { "Samsung", "IPhone", "Realme", "Redmi", "Vivo", "Nokia", "OnePlus", "Oppo", "Sony", "Motorola" };


            foreach(string mobiles in brand1) {

                Console.WriteLine(mobiles);
    


            }
        }
    }
}
