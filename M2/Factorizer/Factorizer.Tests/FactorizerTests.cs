using Factorizer.BLL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer.Tests
{
    [TestFixture]
    public class FactorizerTests
    {
        [Test]
        public void FindFactorTest()
        {
            FactorFinder finderInstance = new FactorFinder();
            int[] expected = new int[] { 1, 2, 4 };

            int[] actual = (int[])finderInstance.FindFactors(4);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckIfPerfectTest()
        {
            PerfectChecker perfectChecker = new PerfectChecker();
            int[] arrayToSum = new int[] { 1, 2, 3, 6 };

            bool expected = true;

            bool actual = perfectChecker.CheckIfPerfect(arrayToSum, 6);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckIfPrimeTest()
        {
            PrimeChecker primeChecker = new PrimeChecker();
            int[] numArray = new int[] { 1, 5 };

            bool expected = true;

            bool actual = primeChecker.CheckIfPrime(numArray, 5);
            Assert.AreEqual(expected, actual);
        }
    }
}
