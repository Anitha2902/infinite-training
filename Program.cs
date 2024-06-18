using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sine
{
    class Program
    {
        public static void Main(string[] args)
        {

            int num;
            Console.Write("\n\n");
            Console.Write("check whether a number is positive or negative");
            Console.Write("\n\n");
            Console.Write("enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
                Console.WriteLine("{0} is a positive number.", num);
            else
                Console.WriteLine("{0} is a negative number.", num);
            Console.ReadLine();

        }
    }
}


    

    
