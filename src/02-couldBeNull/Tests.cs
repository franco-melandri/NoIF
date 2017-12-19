using NUnit.Framework;

namespace Tests
{
    public class CouldBeNullTests
    {
        private CouldBeNull.CouldBeNull sut;

        [SetUp]
        public void Setup()
        {
            sut = new CouldBeNull.CouldBeNull();
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

        [Test]
        public void AsMain() {
            var response = sut.getResponse("1212");
            if (response != null)
                System.Console.WriteLine (response.message);
            else
                System.Console.WriteLine ("No Id !!!!");

            response = sut.getResponse("ASC");
            if (response != null)
                System.Console.WriteLine (response.message);
            else
                System.Console.WriteLine ("No Id !!!!");

            Assert.IsTrue(true);
        }
    }



    public class CallbackNoIfTests
    {
        private CouldBeNull.Callback sut;

        [SetUp]
        public void Setup()
        {
            sut = new CouldBeNull.Callback();
        }

        [Test]
        public void ShouldgetWrongReponse()
        {
            const string id = "invalidId";
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

        [Test]
        public void AsMain() {
            sut.getResponse("invalidId",
                            (res) => System.Console.WriteLine ("No Id !!!!"),
                            (res) => System.Console.WriteLine (res.message));
            sut.getResponse("123",
                            (res) => System.Console.WriteLine ("No Id !!!!"),
                            (res) => System.Console.WriteLine (res.message));
            Assert.IsTrue(true);
        }
    }
}
