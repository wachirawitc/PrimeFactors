using PrimeFactors.Interface;
using System.Collections.Generic;

namespace PrimeFactors.Internal
{
    public class DefaultPrimeNumber : IPrimeNumber
    {
        private readonly int maximum;

        public DefaultPrimeNumber(int maximum)
        {
            this.maximum = maximum;
        }

        public List<int> Sources
        {
            get
            {
                var primes = new List<int>();
                bool isPrime = true;

                for (int prime = 1; prime <= maximum; prime++)
                {
                    for (int number = 2; number <= maximum; number++)
                    {
                        if (IsNotPrime(prime, number))
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime && prime != 1)
                    {
                        primes.Add(prime);
                    }

                    isPrime = true;
                }

                return primes;
            }
        }

        private static bool IsNotPrime(int prime, int number)
        {
            return prime != number && prime % number == 0;
        }
    }
}