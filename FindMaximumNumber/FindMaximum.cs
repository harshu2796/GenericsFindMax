﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    public class FindMaximum
    {
        public int FindMaxInteger(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First Number is greater: " + first);
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second Number is greater: " + first);
                return second;
            }
            else
            {
                Console.WriteLine("Third Number is greater: " + third);
                return third;
            }
        }
    }
}