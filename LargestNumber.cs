﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programss
{
    internal class LargestNumber
    {
        public static void Number()
        {
            Console.WriteLine("Enter a first num: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second num: ");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a third num: ");
            int third = int.Parse(Console.ReadLine());


            if (first > second && first > third)
            {
                Console.WriteLine(first + " is  greater than " + second + " and " + third);
            }
            else if (second > third)
            {
                Console.WriteLine(second + " is  greater than " + first + " and " + third);
            }
            else
            {
                Console.WriteLine(third + " is  greater than " + first + " and" + second);
            }
        }
    }
}


