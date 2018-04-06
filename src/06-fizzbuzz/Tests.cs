using NUnit.Framework;

namespace FizzBuzz {
    
    [TestFixture]
    public class FirstTests
    {    
        [TestCase(1, "1")]
        [TestCase(3, "fizz")]
        [TestCase(5, "buzz")]
        [TestCase(3*5, "fizzbuzz")]
        public void ShouldResolveFirstFizzBuzz(int value, string expected) 
        {
            var result = new First().Get(value);
            Assert.AreEqual (result, expected);              
        }
    
        [TestCase(1, "1")]
        [TestCase(3, "fizz")]
        [TestCase(5, "buzz")]
        [TestCase(3*5, "fizzbuzz")]
        public void ShouldResolveSecondFizzBuzz(int value, string expected) 
        {
            var result = new Second().Get(value);
            Assert.AreEqual (result, expected);              
        }
    }
}