using PrimeFactors.Interface;
using System.Collections.Generic;
using PrimeFactors.Internal;

namespace PrimeFactors
{
    public class PrimeFactorManagement
    {
        private readonly IPrimeNumber primeNumber;

        public PrimeFactorManagement(IPrimeNumber primeNumber)
        {
            this.primeNumber = primeNumber;
        }

        public List<int> GetFactors(int value)
        {
            var model = new List<int>();

            var scanner = new Scanner<int>(primeNumber.Sources);
            while (scanner.HasNext() && value > 1)
            {
                var prime = scanner.Value;
                if (CanDivision(value, prime))
                {
                    value = value - (value / prime);
                    model.Add(prime);
                }
                else
                {
                    scanner.Next();
                }
            }
            return model;
        }

        private static bool CanDivision(int value, int prime)
        {
            return value % prime == 0;
        }
    }
}