using System;
using System.Collections.Generic;

namespace PingPong
{
    public class PingPong
    {
        // private List<PingPong> output = new List<PingPong>();
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
        // this is the method that actually generates the array with the numbers and their replacements
        // in for loop, i-1 is the index because we start at 1 for the counting part, 0 for the array
        public string[] PingPongOutput(int number)
        {
            PingPong pingPong1 = new PingPong();
            string[] pingPongArray = new String[number];
            for (int i=1; i <= number; i++)
            {
                pingPongArray[i-1] = pingPong1.outputForSingleNumber(i);
            }
            return pingPongArray;
            // string[] output = new string[] {"1"};
            // return output;
        }
    }
}