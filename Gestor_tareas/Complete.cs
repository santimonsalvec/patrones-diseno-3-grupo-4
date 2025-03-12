namespace TaskManager
{

    public class Complete : ICommand
    {
        private Task _task;
    
        public Complete(Task task)
        {
            _task = task;
        }
        
        public void Execute()
        {
            _task.IsCompleted = true;
            Console.WriteLine($"Tarea '{_task.Name}' marcada como completada.");
        }
        
        public void Undo()
        {
            _task.IsCompleted = false;
            Console.WriteLine($"Reversión: Tarea '{_task.Name}' marcada como pendiente.");
        }
    }
}