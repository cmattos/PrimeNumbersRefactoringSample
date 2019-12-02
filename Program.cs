using System;

namespace PrimeNumbersRefactoringSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = GeneratePrimes.GeneratePrimeNumbers(50);

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i].ToString());
            }

            Console.ReadLine();
        }
    }
}
