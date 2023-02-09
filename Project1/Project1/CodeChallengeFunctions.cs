using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class CodeChallengeFunctions
    {
        public long LargestPrimeFactor(long testNumber)
        {
            List<long> primeNumbers = new List<long>();
            long checkNumber = 2;

            while (checkNumber < testNumber)
            {
                bool isPrime = true;

                foreach (long number in primeNumbers)
                {
                    if (checkNumber % number == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumbers.Add(checkNumber);
                    while (testNumber % checkNumber == 0)
                    {
                        testNumber = testNumber / checkNumber;
                    }
                }
                if (checkNumber < testNumber)
                {
                    checkNumber++;
                }
            }
            return checkNumber;
        }

        public int LargestPalindromeProduct()
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
            return (maxPalindrome);
        }
    }
}
