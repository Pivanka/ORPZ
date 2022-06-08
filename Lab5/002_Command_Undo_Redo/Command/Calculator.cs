using System;

namespace Command
{
    /// <summary>
    /// User interface with typesetting field with buttons for numbers, cancel characters
    /// and repeat operations, as well as a panel for displaying the result
    /// </summary>
    class Calculator
    {
        ArithmeticUnit arithmeticUnit;
        ControlUnit controlUnit;

        public Calculator()
        {
            arithmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }

        private float Run(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.Register;
        }

        public float Add(float operand)
        {
            return Run(new Add(arithmeticUnit, operand));
        }

        public float Mul(float operand)
        {
            return Run(new Mul(arithmeticUnit, operand));
        }

        public float Div(float operand)
        {
            return Run(new Div(arithmeticUnit, operand));
        }

        public float Undo(int levels)
        {
            controlUnit.Undo(levels);
            return arithmeticUnit.Register;
        }

        public float Redo(int levels)
        {
            controlUnit.Redo(levels);
            return arithmeticUnit.Register;
        }
    }
}
