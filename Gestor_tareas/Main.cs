
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace TaskManager
{
   
  public class Program
	{
		public static void Main(string[] args)
		{
			TaskReceiver taskReceiver = new TaskReceiver();
			CommandManager commandManager = new CommandManager();
			
			Task task1 = new Task("Comprar leche");
			Task task2 = new Task("Hacer ejercicio");

			ICommand addTask1 = new Create(taskReceiver, task1);
			ICommand addTask2 = new Create(taskReceiver, task2);
			ICommand completeTask1 = new Complete(task1);

			ICommand deleteTask1 = new Delete(taskReceiver, task1);

			ICommand editTask1 = new Edit(taskReceiver, task1, "Lavar la loza");
			
			commandManager.ExecuteCommand(addTask1);
			commandManager.ExecuteCommand(addTask2);
			taskReceiver.ShowTasks();
			
			commandManager.ExecuteCommand(completeTask1);
			taskReceiver.ShowTasks();
			
			
			commandManager.UndoLastCommand();
			commandManager.ExecuteCommand(deleteTask1);
			taskReceiver.ShowTasks();
			commandManager.UndoLastCommand();
			taskReceiver.ShowTasks();

			commandManager.ExecuteCommand(editTask1);
			taskReceiver.ShowTasks();
			commandManager.UndoLastCommand();
			taskReceiver.ShowTasks();

		}
	}
}