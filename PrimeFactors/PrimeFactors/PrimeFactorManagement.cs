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
            var model = new List<int>();
            foreach (var number in GetCommonPlus(value))
            {
                if (IsNotPrimeNumber(number))
                {
                    model.AddRange(GetCommonPlus(number));
                }
                else
                {
                    model.Add(number);
                }
            }

            return model.OrderBy(number => number).ToList();
        }

        private bool IsNotPrimeNumber(int value)
        {
            return primes.Any(number => number == value) == false;
        }

        private IEnumerable<int> GetCommonPlus(int value)
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

            var results = new List<int>();
            foreach (var item in items.GroupBy(x => x))
            {
                results.Add(item.Key);

                if (item.Count() > 1)
                {
                    results.Add(item.Count());
                }
            }

            return results.OrderBy(number => number).ToList();
        }
    }
}