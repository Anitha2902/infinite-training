﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class equal
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("the integers are equal.");
            }
            else
            {
                Console.WriteLine("the integers are not equal.");
            }
        }
    }
}


   