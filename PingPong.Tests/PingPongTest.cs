using Microsoft.VisualStudio.TestTools.UnitTesting;

using PingPong;

namespace PingPong.Tests
{
    [TestClass]
    public class PingPongTest
    {
        [TestMethod]
        public void checkInputIsInt_InputIsInt_true()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(true, testPingPong.checkInputIsInt("1"));
        }
        [TestMethod]
        public void checkInputIsInt_InputIsNotInt_false()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(false, testPingPong.checkInputIsInt("a"));
        }

        [TestMethod]
        public void checkInputDivisibleBy15_NumberDivisibleBy15_true()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(true, testPingPong.checkInputDivisibleBy15(15));
        }
        [TestMethod]
        public void checkInputDivisibleBy15_NumberNotDivisibleBy15_false()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(false, testPingPong.checkInputDivisibleBy15(1));
        }
        // [TestMethod]
        // public void PingPongOutput_1AsUserInput_Returns1()
        // {
        //     PingPong testPingPong = new PingPong();
        //     string[] testOutput = testPingPong.PingPongOutput(1);
        //     string[] temp = new string[] {"1"};
        //     CollectionAssert.AreEqual(temp, testOutput);
        // }
    }
}