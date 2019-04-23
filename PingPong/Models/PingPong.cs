using System;

namespace PingPong
{
    public class PingPong
    {
        public bool checkInputIsInt(string userInput)
        {
            int myInt;
            bool isInt = int.TryParse(userInput, out myInt);
            return isInt;
        }
        public bool checkInputDivisibleBy15(int userInput)
        {
            return userInput % 15 == 0;
        }
        public string[] PingPongOutput(int number)
        {
            string[] output = new string[] {"1"};
            return output;
        }
    }
}