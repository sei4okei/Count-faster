using System;
using System.Collections.Generic;
using System.Text;

namespace mathOnFingers.AppData
{
    internal class FirstLevelLogic
    {
        public int firstNumber;
        public int mathOperatorNumber;
        public char mathOperator;
        public int secondNumber;
        public int winAnswer;
        public int winButton;
        public int firstButtonText;
        public int secondButtonText;
        public int thirdButtonText;

        public void NumberGenerator()
        {
            Random rnd = new Random();
            firstNumber = rnd.Next(1, 10);
            secondNumber = rnd.Next(1, 10);
            mathOperatorNumber = rnd.Next(0, 2);
            winButton = rnd.Next(0, 3);
            firstButtonText = rnd.Next(1, 19);
            secondButtonText = rnd.Next(1, 19);
            thirdButtonText = rnd.Next(1, 19);
            mathOperator = GetMathOperatorAndWinAnswer(mathOperatorNumber);
        }

        public char GetMathOperatorAndWinAnswer(int num)
        {
            switch (num)
            {
                case 0:
                    while (firstNumber <= secondNumber)
                    {
                        NumberGenerator();
                    }
                    winAnswer = firstNumber - secondNumber;
                    return '-';

                case 1:
                    winAnswer = firstNumber + secondNumber;
                    return '+';

                default:
                    winAnswer = firstNumber + secondNumber;
                    return '+';
            }
        }

    }
}
