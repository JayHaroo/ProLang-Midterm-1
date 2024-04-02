using System;

class Analyzer
{
    static void Main(String[] args)
    {
        String syntax = Console.ReadLine();
        String cutSyn = syntax.Trim();

        int num1 = cutSyn[0] - '0';
        int num2 = cutSyn[4] - '0';

        int sum = num1 + num2;
        int sub = num1 - num2;
        int mul = num1 * num2;
        int div = num1 / num2;

        Console.WriteLine("=================");

        if (cutSyn[2] == '+')
        {
            Console.WriteLine(cutSyn + " = " + sum);
            Console.WriteLine("+ = Addition Operator");
        }
        else if (cutSyn[2] == '-')
        {
            Console.WriteLine(cutSyn + " = " + sub);
            Console.WriteLine("- = Subtraction Operator");
        }
        else if (cutSyn[2] == '*')
        {
            Console.WriteLine(cutSyn + " = " + mul);
            Console.WriteLine("* = Multiply Operator");
        }
        else if (cutSyn[2] == '/')
        {
            Console.WriteLine(cutSyn + " = " + div);
            Console.WriteLine("/ = Division Operator");
        }
        else
        {
            Console.WriteLine("Ënter valid operation");
        }

        Console.WriteLine(Convert.ToString(cutSyn[0]) + " = Integer Literal");
        Console.WriteLine(Convert.ToString(cutSyn[4]) + " = Integer Literal");
    }
}