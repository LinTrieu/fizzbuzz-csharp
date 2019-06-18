using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class Fizzbuzz_ShouldReturn
    {
        private readonly PrimeService _primeService;

        // public PrimeService_IsPrimeShould()
        // {
        //     _primeService = new PrimeService();
        // }

        [Test]
        public void ReturnNumber()
        {
            var result = PrimeService.Fizzbuzz(1);
            Assert.AreEqual("1", result);
            }
        
        [Test]
        public void ReturnsFizz()
        {
            var result = PrimeService.Fizzbuzz(9);
            Assert.AreEqual("Fizz", result);
            }
            
        [Test]
        public void ReturnsBuzz()
        {
            var result = PrimeService.Fizzbuzz(5);
            Assert.AreEqual("Buzz", result);
            }
    }
}