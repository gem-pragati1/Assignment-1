using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class ques7
    {
        public void solution()
        {
            string[] letters = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter letter: ");
                letters[i] = Console.ReadLine();
            }
            Console.WriteLine("==After reverse==");
            for (int j = 2; j >= 0; j--)
            {
                Console.Write(letters[j] + " ");
            }
        }
    }
}
