using System;

namespace Command
{
    /// <summary>
    /// Special command multiplying operand.
    /// </summary>
    class Mul : Command
    {
        public Mul(ArithmeticUnit unit, float operand)
        {
            Unit = unit;
            Operand = operand;
        }

        public ArithmeticUnit Unit { get; set; }
        public float Operand { get; set; }

        public void Execute()
        {
            Unit.Run('*', Operand);
        }

        public void UnExecute()
        {
            Unit.Run('/', Operand);
        }
    }
}
