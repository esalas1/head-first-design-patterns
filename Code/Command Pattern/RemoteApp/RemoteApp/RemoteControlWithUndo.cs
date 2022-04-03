using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteApp
{
    public class RemoteControlWithUndo
    {
        Command[] OnCommands;
        Command[] OffCommands;
        Command UndoCommand;

        int TotalNumberOfCommands = 7;

        public RemoteControlWithUndo()
        {
            OnCommands = new Command[TotalNumberOfCommands];
            OffCommands = new Command[TotalNumberOfCommands];

            Command noCommand = new NoCommand();

            for (int i = 0; i < TotalNumberOfCommands; i++)
            {
                OnCommands[i] = noCommand;
                OffCommands[i] = noCommand;
            }

            UndoCommand = noCommand;
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            OnCommands[slot] = onCommand;
            OffCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            Command currentCommand = OnCommands[slot];
            currentCommand.Execute();
            UndoCommand = currentCommand;
        }

        public void OffButtonWasPushed(int slot)
        {
            Command currentCommand = OffCommands[slot];
            currentCommand.Execute();
            UndoCommand = currentCommand;
        }

        public void UndoButtonWasPushed()
        {
            UndoCommand.Undo();
        }
    }
}
