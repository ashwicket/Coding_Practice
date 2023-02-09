using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class LargestPalindromeProduct
    {
        public static void Main(string[] args)
        {
            int maxPalindrome = 0;

            //First Number Loop
            for (int i = 999; i >= 100; i--)
            {
                //Second Number Loop
                for (int j = 999; j >= i; j--)
                {
                    int number = (i * j);
                    string checkNumber = number.ToString();
                    bool checkPalindrome = true;
                    for (int k = 0; k < checkNumber.Length / 2; k++)
                    {
                        if (checkNumber[k] != checkNumber[checkNumber.Length - k - 1])
                        {
                            //No Palindrome found. Continue
                            checkPalindrome = false;
                            break;
                        }
                    }
                    //Palindrome Found. Check for Max.
                    if (checkPalindrome)
                    {
                        if (number > maxPalindrome)
                        {
                            maxPalindrome = number;
                        }
                    }
                }
            }
            Console.WriteLine(maxPalindrome);
            Console.ReadKey();
        }
    }
}
