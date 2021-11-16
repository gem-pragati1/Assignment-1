using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class ques6
    {
        public void solution()
        {
            string ActualUsername = "pr.gupta6";
            string ActualPassword = "Qwerty@6";
            int attempts = 3;
            int count = 0;
            while (attempts > 0)
            {
                if (attempts < 3)
                {
                    Console.WriteLine("WRONG USERNAME OR PASSWORD!");
                    Console.WriteLine(attempts + " attempts left.....");
                }
                Console.WriteLine("Enter username and password:");
                Console.Write("Username: ");
                String testUsername = Console.ReadLine();
                Console.Write("Password: ");
                String testPassword = Console.ReadLine();

                if (ActualUsername == testUsername && ActualPassword == testPassword)
                {
                    count = 1;
                    break;
                }

                attempts--;
            }

            if (count == 1)
            {
                Console.WriteLine("Welcome " + ActualUsername);
            }
            else
            {
                Console.WriteLine("Try after 24 hrs. -- Wrong Credentials --");
            }
        }
    }
}
