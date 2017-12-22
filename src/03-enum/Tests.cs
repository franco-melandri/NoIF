using NUnit.Framework;
using Moq;
using EnumSnippet;

namespace Tests
{
    public class CommandsSwitchTests
    {
        private CommandsSwitch sut;
        private Mock<ILogger> logger;

        [SetUp]
        public void Setup()
        {
            logger = new Mock<ILogger>();
            sut = new CommandsSwitch(logger.Object);
        }
        
        [Test]
        public void ShouldGetRightMessageFotInitStart()
        {
            sut.Do(Actions.Start, States.Init);
            logger.Verify (m => m.Log(Messages.INIT_START));
        }        

        [Test]
        public void ShouldGetRightMessageFotDeInitStart()
        {
            sut.Do(Actions.Start, States.DeInit);
            logger.Verify (m => m.Log(Messages.DEINIT_START));
        }
        
        [Test]
        public void ShouldGetRightMessageFotInitStop()
        {
            sut.Do(Actions.Stop, States.Init);
            logger.Verify (m => m.Log(Messages.INIT_STOP));
        }

        [Test]
        public void ShouldGetRightMessageFotDeInitStop()
        {
            sut.Do(Actions.Stop, States.DeInit);
            logger.Verify (m => m.Log(Messages.DEINIT_STOP));
        }        
    }

    public class CommandsIfTests
    {
        private CommandsIf sut;
        private Mock<ILogger> logger;

        [SetUp]
        public void Setup()
        {
            logger = new Mock<ILogger>();
            sut = new CommandsIf(logger.Object);
        }
        
        [Test]
        public void ShouldGetRightMessageFotInitStart()
        {
            sut.Do(Actions.Start, States.Init);
            logger.Verify (m => m.Log(Messages.INIT_START));
        }        

        [Test]
        public void ShouldGetRightMessageFotDEInitStart()
        {
            sut.Do(Actions.Start, States.DeInit);
            logger.Verify (m => m.Log(Messages.DEINIT_START));
        } 
        
        [Test]
        public void ShouldGetRightMessageFotInitStop()
        {
            sut.Do(Actions.Stop, States.Init);
            logger.Verify ( m => m.Log(Messages.INIT_STOP));
        }        

        [Test]
        public void ShouldGetRightMessageFotDeInitStop()
        {
            sut.Do(Actions.Stop, States.DeInit);
            logger.Verify (m => m.Log(Messages.DEINIT_STOP));
        }             
    }
    public class CommandsNoIfTests
    {
        private CommandsNoIf sut;
        private Mock<ILogger> logger;

        [SetUp]
        public void Setup()
        {
            logger = new Mock<ILogger>();
            sut = new CommandsNoIf(logger.Object);
        }
        
        [Test]
        public void ShouldGetRightMessageFotInitStart()
        {
            sut.Do(Actions.Start, States.Init);
            logger.Verify (m => m.Log(Messages.INIT_START));
        }        

        [Test]
        public void ShouldGetRightMessageFotDEInitStart()
        {
            sut.Do(Actions.Start, States.DeInit);
            logger.Verify (m => m.Log(Messages.DEINIT_START));
        } 
        
        [Test]
        public void ShouldGetRightMessageFotInitStop()
        {
            sut.Do(Actions.Stop, States.Init);
            logger.Verify (m => m.Log(Messages.INIT_STOP));
        }        

        [Test]
        public void ShouldGetRightMessageFotDeInitStop()
        {
            sut.Do(Actions.Stop, States.DeInit);
            logger.Verify (m => m.Log(Messages.DEINIT_STOP));
        }             
    }
}