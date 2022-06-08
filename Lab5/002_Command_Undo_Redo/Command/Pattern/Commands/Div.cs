using System;

namespace Command
{
    /// <summary>
    /// Special command dividing operand.
    /// </summary>
    class Div : Command
    {
        public Div(ArithmeticUnit unit, float operand)
        {
            Unit = unit;
            Operand = operand;
        }

        public ArithmeticUnit Unit { get; set; }
        public float Operand { get; set; }

        public void Execute()
        {
            Unit.Run('/', Operand);
        }

        public void UnExecute()
        {
            Unit.Run('*', Operand);
        }
    }
}
