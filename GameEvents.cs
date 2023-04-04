using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    public class GameEvents
    {
        public int RandomNum;
        private int InputCount;

        public int NumGenerator()
        {
            Random random = new Random();
            RandomNum = random.Next(1, 11);
            return RandomNum;
        }

        public int GetUserAnswer()
        {
            int UserInput;
            UserInput = Convert.ToInt32(Console.ReadLine());
            return UserInput;
        }
        public int GetInputCount()
        {
            InputCount++;
            return InputCount;
        }
    }
}
