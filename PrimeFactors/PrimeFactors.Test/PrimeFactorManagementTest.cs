using NUnit.Framework;
using PrimeFactors.Interface;

namespace PrimeFactors.Test
{
    [TestFixture]
    public class PrimeFactorManagementTest
    {
        [Test]
        public void TestMethod1()
        {
            IPrimeNumber primeNumber = new DefaultPrimeNumber(100);
        }
    }
}