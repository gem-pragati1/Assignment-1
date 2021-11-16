using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class ques4
    {
        public void solution()
        {
            Console.WriteLine("First no. :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            if ((a >= -10 && a <= 10) || (b <= 10 && b >= -10))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Flase");
            }
        }
    }
}
