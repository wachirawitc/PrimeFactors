using PrimeFactors.Interface;
using System.Collections.Generic;

namespace PrimeFactors
{
    public class PrimeFactorManagement
    {
        private readonly List<int> primes;

        public PrimeFactorManagement(IPrimeNumber primeNumber)
        {
            primes = primeNumber.Sources;
        }

        public List<int> GetFactors(int value)
        {
            int temporary = value;

            var items = new List<int>();
            foreach (var prime in primes)
            {
                if (temporary % prime == 0 && temporary != 0)
                {
                    for (int number = temporary; number >= prime; number -= prime)
                    {
                        items.Add(prime);
                        temporary -= prime;
                    }
                }
            }



            return items;
        }
    }
}