using PrimeFactors.Interface;
using System.Collections.Generic;

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
                if (value % prime == 0)
                {
                    model.Add(prime);
                    value = value - (value / prime);
                }
                else
                {
                    scanner.Next();
                }
            }
            return model;
        }
    }
}