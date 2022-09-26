using System;
using static System.Console;
namespace Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(IsValid("({{{{}}}))"));
        }
        
        static bool IsValid(string s) {
            Stack<char> stack = new Stack<char>();
            foreach (var c in s.ToArray())
            {
                switch(c)
                {
                    case '(':
                    case '[':
                    case '{':
                            stack.Push(c);
                    break;

                    case ')':
                        if (stack.Contains('(') && stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    break;

                    case ']':
                        if (stack.Contains('[') && stack.Peek() == '[')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    break;

                    case '}':
                        if (stack.Contains('{') && stack.Peek() == '{')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    break;
                }
            }
        return (stack.Count == 0) ? true: false;
        }
    }
}