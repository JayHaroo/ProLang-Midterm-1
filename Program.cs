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
        string opp = "";

        Console.WriteLine("=================");

        if (cutSyn[2] == '+')
        {
            Console.WriteLine(cutSyn + " = " + sum);
            opp = "+";
        }
        else if (cutSyn[2] == '-')
        {
            Console.WriteLine(cutSyn + " = " + sub);
            opp = "-";
        }
        else if (cutSyn[2] == '*')
        {
            Console.WriteLine(cutSyn + " = " + mul);
            opp = "*";
        }
        else if (cutSyn[2] == '/')
        {
            Console.WriteLine(cutSyn + " = " + div);
            opp = "/";
        }
        else
        {
            Console.WriteLine("Ënter valid operation");
        }

        Console.WriteLine(Convert.ToString(cutSyn[0]) + " = Integer Literal");
        Console.WriteLine(opp + " = Operator");
        Console.WriteLine(Convert.ToString(cutSyn[4]) + " = Integer Literal");
        Console.WriteLine("= = Equal Operator");
    }
}