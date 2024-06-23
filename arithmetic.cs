using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            char operation;
            Console.WriteLine("enter first number:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input operation:");
            operation = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter second number:");
            y = Convert.ToInt32(Console.ReadLine());
            if (operation == '+')
                Console.WriteLine("{0}+{1}={2}", x, y, x + y);
            else if (operation == '-')
                Console.WriteLine("{0}-{1}={2}", x, y, x - y);
            else if (operation == '*')
                Console.WriteLine("{0}*{1}={2}", x, y, x * y);
            else if (operation == '/')
                Console.WriteLine("{0}/{1}={2}", x, y, x / y);
            else
                Console.WriteLine("wrong");
        }
    }


}

