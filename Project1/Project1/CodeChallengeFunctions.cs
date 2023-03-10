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

        public int SmallestDivisibleNumber(int min, int max)
        {
            if ((min <= 0) || (max < min))
            {
                return 0;
            }
            else if (max == min)
            {
                return min;
            }
            else
            {
                int number = max * min;
                bool numberCheck = false;

                while (!numberCheck)
                {
                    numberCheck = true;
                    for (int i = min; i <= max; i++)
                    {
                        // Check if number is divisible
                        if ((number % i) != 0)
                        {
                            // Number not divisible
                            numberCheck = false;
                            break;
                        }
                    }
                    if (!numberCheck)
                    {
                        // Divisible number not found
                        number++;
                    }
                }

                return number;
            }
        }

        public int SumSquareDiffernence(int maxNum)
        {
            if (maxNum <= 0)
            {
                return 0;
            }
            else
            {
                int sumSquare = 0;
                int squareSum = 0;

                for (int i = 1; i <= maxNum; i++)
                {
                    sumSquare += i * i;
                    squareSum += i;
                }
                squareSum = squareSum * squareSum;

                return squareSum - sumSquare;
            }
        }

        public int FindPrimeNumber(int number)
        {
            if (number <= 0)
                return 0;

            List<int> primeNumbers = new List<int>();
            int currentNumber = 2;
            int currentPrimeNumber = 2;
            primeNumbers.Add(2);

            for (int i = 2; i <= number; i++)
            {
                bool primeNumberFound = false;
                while (primeNumberFound == false)
                {
                    currentNumber++;
                    primeNumberFound = true;

                    foreach (int primeNumber in primeNumbers)
                    {
                        if (currentNumber % primeNumber == 0)
                        {
                            primeNumberFound = false;
                            break;
                        }
                    }
                }
                currentPrimeNumber = currentNumber;
                primeNumbers.Add(currentPrimeNumber);
            }

            return currentPrimeNumber;
        }

        public long LargestSeriesProduct(string series, int checkLength)
        {
            if (series.Length < checkLength)
                return 0;

            List<int> currentNumbers = new List<int>();
            long currentProduct = 1;
            long largestProduct = 1;
            int currentZeroIndex = -1;

            for (int i = 0; i < series.Length; i++)
            {
                // Get Number in Series
                long number = long.Parse(series[i].ToString());
                currentNumbers.Add(((int)number));

                // Check if 0 is in Series
                if (number == 0)
                    currentZeroIndex = currentNumbers.Count - 1;

                if (currentNumbers.Count == checkLength)
                {
                    // If 0 is in Series, Reset the Product
                    if (currentZeroIndex >= 0)
                        currentProduct = 1;

                    // If 0 is Not in Series, Multiply the Whole Series
                    else if (currentZeroIndex == -1)
                    {
                        currentProduct = 1;
                        foreach (long currentNumber in currentNumbers)
                            currentProduct *= currentNumber;
                    }
                    // Otherwise, Multiply Just the New Number
                    else
                        currentProduct *= number;

                    // Check if Largest Product
                    if (currentProduct > largestProduct)
                        largestProduct = currentProduct;

                    // If 0 is Not in Series, Divide First Number
                    if (currentZeroIndex < 0)
                        currentProduct /= currentNumbers[0];

                    currentZeroIndex--;
                    // Remove First Number to Make Room for Next Number
                    currentNumbers.RemoveAt(0);
                }
            }

            return largestProduct;
        }
    }
}
