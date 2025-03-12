using System;

namespace TaskManager
{
	public interface ICommand
	{
		void Execute();
		void Undo();
	}
}