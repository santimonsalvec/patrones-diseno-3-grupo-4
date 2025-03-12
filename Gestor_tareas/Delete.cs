
namespace TaskManager
{

    public class Delete : ICommand
    {
        private readonly TaskReceiver _receiver;
        private readonly Task _task;

        public Delete(TaskReceiver receiver, Task task)
        {
            _receiver = receiver;
            _task = task;
        }

        public void Execute()
        {
            _receiver.RemoveTask(_task);
            
        }

        public void Undo()
        {
            _receiver.AddTask(_task);
        }
    }
}