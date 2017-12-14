using NUnit.Framework;

namespace Tests
{
    public class CallbackTests
    {
        private Callback.Callback sut;

        [SetUp]
        public void Setup()
        {
            sut = new Callback.Callback();
        }

        [Test]
        public void ShouldgetWrongReponse()
        {
            const string id = "ivalidId";
            var response = sut.getResponse(id);
            Assert.AreEqual(response, null);
        }
    
        [Test]
        public void ShouldgetRightReponse()
        {
            const string id = "123";
            var response = sut.getResponse(id);
            Assert.AreNotEqual(response, null);
            Assert.AreEqual(response.message, "Your id is 123");
        }
    }

    public class CallbackNoIfTests
    {
        private Callback.CallbackNoIf sut;

        [SetUp]
        public void Setup()
        {
            sut = new Callback.CallbackNoIf();
        }

        [Test]
        public void ShouldgetWrongReponse()
        {
            const string id = "ivalidId";
            sut.getResponse(id, 
                            (response) => Assert.IsTrue(true),
                            (response) => Assert.Fail()) ;
        }
    
        [Test]
        public void ShouldgetRightReponse()
        {
            const string id = "123";
            sut.getResponse(id, 
                            (response) => Assert.Fail(),
                            (response) => Assert.IsTrue(true)) ;
        }
    }
}
