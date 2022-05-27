using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("redder"));
            Console.WriteLine(IsPalindrome("alpha"));
        }

        public static bool IsPalindrome(string s)
        {
            bool result = false;
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string reverseString = new string(charArray);
            if (s == reverseString)
            {
                result = true;
            }

            return result;
        }
    }
}
