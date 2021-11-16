using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class ques3
    {
        public void solution()
        {
            Console.WriteLine("Enter a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            int b = Convert.ToInt32(Console.ReadLine());
            int c;
            c = a + b;
            a = c - a;
            b = c - a;
            Console.WriteLine("After Swapping:");
            Console.WriteLine("a=" + a + " and b=" + b);
        }
    }
}
