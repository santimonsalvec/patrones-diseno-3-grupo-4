
namespace TaskManager
{

    public class Edit : ICommand
    {
         private TaskReceiver _taskReceiver;
        private Task _task;
        private string _newTask;
        private string _oldTask;
        
        public Edit(TaskReceiver receiver, Task task, string newTask)
        {
            _taskReceiver = receiver;
            _task = task;
            _newTask = newTask;
            _oldTask = task.Name;
        }
        
        public void Execute()
        {
            _oldTask = _task.Name;
            _taskReceiver.EditTask(_task, _newTask);
        }
        
        public void Undo()
        {

            _taskReceiver.EditTask(_task, _oldTask);
        }
    }
}