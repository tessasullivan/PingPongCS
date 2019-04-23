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
        public bool checkInputDivisibleBy5(int userInput)
        {
            return userInput % 5 == 0;
        }

        public bool checkInputDivisibleBy3(int userInput)
        {
            return userInput % 3 == 0;
        }
        public string outputForSingleNumber(int userInput)
        {
            if (checkInputDivisibleBy15(userInput))
            {
                return "ping-pong";
            }
            else if (checkInputDivisibleBy5(userInput))
            {
                return "pong";
            }
            else if (checkInputDivisibleBy3(userInput))
            {
                return "ping";
            }
            else
            {
                return userInput.ToString();
            }
        }
        public string[] PingPongOutput(int number)
        {
            string[] output = new string[] {"1"};
            return output;
        }
    }
}