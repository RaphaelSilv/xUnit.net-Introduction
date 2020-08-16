using System;
using static System.Console;
using PrimeFactoringLib;

namespace ShowPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new PrimeFactoring();

            var primeFactors = calc.GetPrimeFactors(87);

            primeFactors.ForEach( x => {
                Write($"{x} ");
            });
        }
    }
}
