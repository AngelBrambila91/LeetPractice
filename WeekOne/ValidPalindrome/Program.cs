using System;
using static System.Console;
using System.Text.RegularExpressions;
namespace ValidPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        }

    public static bool IsPalindrome(string s)
    {
        Regex rgx = new Regex("[^a-zA-Z0-9]");
        string palindrome = rgx.Replace(s, "");
        palindrome = palindrome.ToLower();
        int lastOneIndex = palindrome.Length - 1;
        for (int i = 0; i <= lastOneIndex; i++)
        {
            if (palindrome[i] == palindrome[lastOneIndex])
            {
                lastOneIndex --;
                continue;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
    }
}