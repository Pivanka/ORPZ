using System;

namespace Command
{
    /// <summary>
    /// After receiving the "signal" (one of
    /// three commands Add, Mul, Div) per input performs an arithmetic operation.
    /// </summary>
    class ArithmeticUnit
    {
        public float Register { get; private set; }

        public void Run(char operationCode, float operand)
        {
            switch (operationCode)
            {
                case '+':
                    Register += operand;
                    break;
                case '-':
                    Register -= operand;
                    break;
                case '*':
                    Register *= operand;
                    break;
                case '/':
                    Register /= operand;
                    break;
            }
        }
    }
}
