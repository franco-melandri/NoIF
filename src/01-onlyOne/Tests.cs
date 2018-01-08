using NUnit.Framework;

namespace Tests
{
    public static class OnlyOneConstants 
    {
        public const string MESSAGE = "message";
        public const string SECOND_MESSAGE = "secondMessage";
    }

    public class OnlyOneUnitTests
    {    
        private OnlyOne.OnlyOne sut;

        [SetUp]
        public void Setup()
        {
            sut = new OnlyOne.OnlyOne();
        }

        [Test]
        public void ShouldGetTheSameMessage()
        {
            var inst = sut.getInstance(OnlyOneConstants.MESSAGE);
            inst = sut.getInstance(OnlyOneConstants.SECOND_MESSAGE);
            Assert.AreEqual(OnlyOneConstants.MESSAGE, inst.message);
        }
    }

    public class OnlyOneNoIfUnitTests
    {    
        private OnlyOne.OnlyOneNoIf sut;

        [SetUp]
        public void Setup()
        {
            sut = new OnlyOne.OnlyOneNoIf();
        }

        [Test]
        public void ShouldGetTheSameMessage()
        {
            var inst = sut.getInstance(OnlyOneConstants.MESSAGE);
            inst = sut.getInstance(OnlyOneConstants.SECOND_MESSAGE);
            Assert.AreEqual(OnlyOneConstants.MESSAGE, inst.message);
        }
    }
}