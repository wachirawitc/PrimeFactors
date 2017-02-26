using NUnit.Framework;
using PrimeFactors.Interface;
using System.Collections.Generic;
using PrimeFactors.Internal;

namespace PrimeFactors.Test
{
    [TestFixture]
    public class PrimeFactorManagementTest
    {
        [Test]
        public void GetFactors_ShouldReturn2_WhenInput2()
        {
            IPrimeNumber primeNumber = new DefaultPrimeNumber(2);
            PrimeFactorManagement management = new PrimeFactorManagement(primeNumber);

            var expected = new List<int> { 2 };
            var actual = management.GetFactors(2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetFactors_ShouldReturn3_WhenInput3()
        {
            IPrimeNumber primeNumber = new DefaultPrimeNumber(3);
            PrimeFactorManagement management = new PrimeFactorManagement(primeNumber);

            var expected = new List<int> { 3 };
            var actual = management.GetFactors(3);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetFactors_ShouldReturn2_2_WhenInput4()
        {
            IPrimeNumber primeNumber = new DefaultPrimeNumber(4);
            PrimeFactorManagement management = new PrimeFactorManagement(primeNumber);

            var expected = new List<int> { 2, 2 };
            var actual = management.GetFactors(4);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetFactors_ShouldReturn2_3_WhenInput6()
        {
            IPrimeNumber primeNumber = new DefaultPrimeNumber(6);
            PrimeFactorManagement management = new PrimeFactorManagement(primeNumber);

            var expected = new List<int> { 2, 3 };
            var actual = management.GetFactors(6);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetFactors_ShouldReturn3_3_WhenInput9()
        {
            IPrimeNumber primeNumber = new DefaultPrimeNumber(9);
            PrimeFactorManagement management = new PrimeFactorManagement(primeNumber);

            var expected = new List<int> { 3, 3 };
            var actual = management.GetFactors(9);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetFactors_ShouldReturn2_2_3_WhenInput12()
        {
            IPrimeNumber primeNumber = new DefaultPrimeNumber(12);
            PrimeFactorManagement management = new PrimeFactorManagement(primeNumber);

            var expected = new List<int> { 2, 2, 3 };
            var actual = management.GetFactors(12);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetFactors_ShouldReturn3_5_WhenInput15()
        {
            IPrimeNumber primeNumber = new DefaultPrimeNumber(15);
            PrimeFactorManagement management = new PrimeFactorManagement(primeNumber);

            var expected = new List<int> { 3, 5 };
            var actual = management.GetFactors(15);

            Assert.AreEqual(expected, actual);
        }
    }
}