using System;
using System.Collections.Generic;

namespace Command
{
    /// <summary>
    /// It organizes all the work of the calculator, issuing in
    /// right moment elementary command objects like: Add, Sub, Mul, Div, Undo, Redo.At
    /// this CU saves the history of the use of commands, and can also undo and restore
    /// previously executed commands.
    /// </summary>
    class ControlUnit
    {
        private List<Command> commands = new List<Command>();                
        private int current = 0;

        public void StoreCommand(Command command)
        {
            commands.Add(command);            
        }

        public void ExecuteCommand()
        {
            commands[current].Execute();
            current++;
        }

        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
                if (current > 0)
                    commands[--current].UnExecute();
        }

        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
                if (current < commands.Count - 1)
                    commands[current++].Execute();
        }
    }
}
