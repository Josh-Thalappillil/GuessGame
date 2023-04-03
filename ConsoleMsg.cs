using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    public static class ConsoleMsg
        
    {
        public static void WelcomeMsg()
        {
            Console.WriteLine("Welcome to GuessGame. \n\nChoose a number between 1 and 10.");
        }
        public static void WinningMsg()
        {
            Console.WriteLine("Congratulations you guessed the correct number");
        }
        public static void TooLow()
        {
            Console.WriteLine("You guessed too low, try again.");
        }
        public static void TooHigh()
        {
            Console.WriteLine("You guessed too high, try again.");
        }
        public static void GoodbyeMsg(int getInputCount)
        {
            Console.WriteLine($"You took {getInputCount} tries to get the answer!");
        }
    }
}
