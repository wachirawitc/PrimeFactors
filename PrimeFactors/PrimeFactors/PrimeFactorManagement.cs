using PrimeFactors.Interface;

namespace PrimeFactors
{
    public class PrimeFactorManagement
    {
        private readonly IPrimeNumber primeNumber;

        public PrimeFactorManagement(IPrimeNumber primeNumber)
        {
            this.primeNumber = primeNumber;
        }
    }
}