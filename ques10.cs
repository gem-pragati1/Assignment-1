using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class ques10
    {
        public void solution()
        {
            Console.WriteLine("For first operation");
            Console.Write("Your first operand:");
            int op1_A = int.Parse(Console.ReadLine());
            Console.Write("Your second operand:");
            int op1_B = int.Parse(Console.ReadLine());
            Console.Write("Enter the first operator:");
            String operator_1 = Console.ReadLine();

            Console.WriteLine("For second operation");
            Console.Write("Your first operand:");
            int op2_A = int.Parse(Console.ReadLine());
            Console.Write("Your second operand:");
            int op2_B = int.Parse(Console.ReadLine());
            Console.Write("Enter the second operator:");
            String operator_2 = Console.ReadLine();

            if (IsResultTheSame(getNumber(op1_A, op1_B, operator_1), getNumber(op2_A, op2_B, operator_2)))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("flase");
            }
        }
        public static bool IsResultTheSame(int a, int b)
        {
            return a == b;
        }

        public static int getNumber(int a, int b, String s)
        {
            switch (s)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "/":
                    return (int)(a / b);
                case "*":
                    return a * b;
                default:
                    Console.WriteLine("Wrong operator given " + s + ". \nAvailable choices [+,-,*,\\]. Considering it as +.");
                    return a + b;
            }
        }

    }
}
