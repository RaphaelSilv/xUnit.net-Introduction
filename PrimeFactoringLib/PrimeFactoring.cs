using System;
using System.Collections.Generic;

namespace PrimeFactoringLib
{
    public class PrimeFactoring
    {
        private static readonly int [] firstOnehundredPrimes = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};
        
        public List<int> GetPrimeFactors(int number)
        {
            var primeFactors = new List<int>();
            int index = 0;
            
            var currentPrime = firstOnehundredPrimes[index];

            if(this.IsPrime(number))
            {
                primeFactors.Add(number);
                return primeFactors;
            }
            else
            {
                var aux = number;
                while(currentPrime <= aux)
                {
                    if(aux % currentPrime == 0)
                    {
                        primeFactors.Add(currentPrime);
                        aux = aux / currentPrime;
                    }
                    else
                    {
                        currentPrime = firstOnehundredPrimes[index++];
                    }
                }
            }
            return primeFactors;
        }

        private bool IsPrime(int number)
        {
            if(number == 2) 
            {
                return true;
            }
            else if(number % 2 == 0 || number <= 1)
            {
                return false;
            }
            else
            {
                for (int num = 2; num <= number / 2; num++)
                {
                    if(number % num  == 0)
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }
    }
}
