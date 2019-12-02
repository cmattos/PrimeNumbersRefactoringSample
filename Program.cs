using System;

namespace PrimeNumbersRefactoringSample
{
    class Program
    {
        static void OldMain(string[] args)
        {
            int[] n = GeneratePrimes.GeneratePrimeNumbers(100);

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i].ToString());
            }

            Console.ReadLine();
        }
    }
}
