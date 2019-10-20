using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "{";
            Console.WriteLine("Status = " + checkBalance(str));
            Console.ReadLine();

}

        public static string checkBalance(string str)
        {
            char[] open = { '{', '[', '(' };
            char[] close = { '}', ']', ')' };
            Stack<char> balBrackets = new Stack<char>(str.Length);

            foreach(Char c in str)
            {
                if(open.Contains(c))
                {
                    balBrackets.Push(c);
                }

                else if (close.Contains(c))
                {
                    if (!balBrackets.Any())
                    {
                        return "NO";
                    }
                    char newitem = balBrackets.Pop();
                    int openIndex = Array.IndexOf(open, newitem);
                    int closeIndex = Array.IndexOf(close, c);
                    if(openIndex != closeIndex)
                    {
                        return "NO";
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    return "NO";
                }

            }
            if (balBrackets.Any())
            {
                return "NO";
            }
            else
            {
                return "YES";
            }
        }
    }
}
