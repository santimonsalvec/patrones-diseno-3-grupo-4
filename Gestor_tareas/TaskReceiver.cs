namespace TaskManager
{
    // Receiver
    public class TaskReceiver
    {
        private List<Task> tasks = new List<Task>();
    
        public void AddTask(Task task)
        {
            tasks.Add(task);
            Console.WriteLine($"Tarea '{task.Name}' creada.");
        }
        
        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
            Console.WriteLine($"Tarea '{task.Name}' eliminada.");
        }

        public void EditTask(Task task, string newName)
        {
            task.Name = newName;
            Console.WriteLine($"Tarea '{task.Name}' actualizada.");
        }
        
        public void CompleteTask(Task task)
        {
            task.IsCompleted = true;
            Console.WriteLine($"Tarea '{task.Name}' completada.");
        }
        
        public void ShowTasks()
        {
            Console.WriteLine("\nLista de tareas:");
            foreach (var task in tasks)
            {
                Console.WriteLine($"- {task.Name} {(task.IsCompleted ? "(Completada)" : "(Pendiente)")}");
            }
        }
    }
}