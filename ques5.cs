using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class ques5
    {
        public void solution()
        {
            Console.WriteLine("First no. :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second no. :");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum;
            if (a == b)
            {
                sum = 3 * (a + b);
            }
            else
            {
                sum = a + b;
            }
            Console.WriteLine("Sum is " + sum);
        }
    }
}
