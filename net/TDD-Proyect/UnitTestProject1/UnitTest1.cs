using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var primeService = new Prime.Services.PrimeService();
            var isPrime = primeService.IsPrime(5);
            Assert.AreEqual(true, isPrime);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var primeService = new Prime.Services.PrimeService();
            var isPrime = primeService.IsPrime(9);

            Assert.AreEqual(false, isPrime);
        }
    }
}
