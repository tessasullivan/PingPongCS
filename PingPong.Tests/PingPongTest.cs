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
        [TestMethod]
        public void checkInputDivisibleBy5_NumberDivisibleBy5ButNot3_true()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(true, testPingPong.checkInputDivisibleBy5(10));
        }
        [TestMethod]
        public void checkInputDivisibleBy5_NumberNotDivisibleBy5_false()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(false, testPingPong.checkInputDivisibleBy5(16));
        }
        [TestMethod]
        public void checkInputDivisibleBy3_NumberDivisibleBy3ButNot5_true()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(true, testPingPong.checkInputDivisibleBy3(9));
        }
        [TestMethod]
        public void checkInputDivisibleBy3_NumberNotDivisibleBy3_false()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual(false, testPingPong.checkInputDivisibleBy3(16));
        }

        [TestMethod]
        public void outputForSingleNumber_NumberDivisibleBy15_pingpong()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual("ping-pong", testPingPong.outputForSingleNumber(15));
        }    
        [TestMethod]
        public void outputForSingleNumber_NumberDivisibleBy5ButNot3_pong()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual("pong", testPingPong.outputForSingleNumber(10));
        }      
        [TestMethod]
        public void outputForSingleNumber_NumberDivisibleBy3ButNot5_ping()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual("ping", testPingPong.outputForSingleNumber(9));
        } 
        [TestMethod]
           public void outputForSingleNumber_NumberNotDivisibleBy3By5By15_userInput()
        {
            PingPong testPingPong = new PingPong();
            Assert.AreEqual("19", testPingPong.outputForSingleNumber(19));
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