using System;

namespace TaskManager
{
	  // Some commands can implement simple operations on their own.
    public class Create : ICommand
    {
        private TaskReceiver _taskReceiver;
        private Task _task;
        
        public Create(TaskReceiver receiver, Task task)
        {
            _taskReceiver = receiver;
            _task = task;
        }
        
        public void Execute()
        {
            _taskReceiver.AddTask(_task);
        }
        
        public void Undo()
        {
            _taskReceiver.RemoveTask(_task);
        }
    }
}