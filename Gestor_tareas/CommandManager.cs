namespace TaskManager {
    public class CommandManager
    {
        private Stack<ICommand> commandHistory = new Stack<ICommand>();
        
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            commandHistory.Push(command);
        }
        
        public void UndoLastCommand()
        {
            Console.WriteLine("Revirtiendo última accion...");
            if (commandHistory.Count > 0)
            {
                ICommand lastCommand = commandHistory.Pop();
                lastCommand.Undo();
            }
            else
            {
                Console.WriteLine("No hay comandos para deshacer.");
            }
        }
    }
}
