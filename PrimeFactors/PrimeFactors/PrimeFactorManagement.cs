using PrimeFactors.Interface;
using System.Collections.Generic;
using System.Linq;

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
            var items = GetCommonPlus(value);

            var model = new List<int>();
            foreach (var item in items)
            {
                if (primes.Any(x => x == item) == false)
                {
                    model.AddRange(GetCommonPlus(item));
                }
                else
                {
                    model.Add(item);
                }
            }

            return model.OrderBy(x => x).ToList();
        }

        private List<int> GetCommonPlus(int value)
        {
            var items = new List<int>();
            foreach (var prime in primes)
            {
                if (value % prime == 0 && value != 0)
                {
                    for (int number = value; number >= prime; number -= prime)
                    {
                        items.Add(prime);
                        value -= prime;
                    }
                }
            }

            List<int> results = new List<int>();
            foreach (var item in items.GroupBy(x => x))
            {
                results.Add(item.Key);

                if (item.Count() > 1)
                {
                    results.Add(item.Count());
                }
            }

            return results.OrderBy(x => x).ToList();
        }
    }
}