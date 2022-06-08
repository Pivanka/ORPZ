using System;

namespace Command
{
    /// <summary>
    /// Special command objects that the CU uses to
    /// AU management. Each command object is associated with an
    /// AU and knows how to manage it correctly.
    /// </summary>
    interface Command
    {
        ArithmeticUnit Unit { get; set; }
        float Operand { get; set; }

        void Execute();
        void UnExecute();
    }
}
