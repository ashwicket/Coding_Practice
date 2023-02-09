using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CodeChallengeFunctions func = new CodeChallengeFunctions();

            Console.WriteLine(func.LargestPrimeFactor(600851475143));
            Console.ReadKey();
        }
    }
}
