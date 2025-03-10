using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clonar_PersonajesV1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var personaje = new Heroes("Hercules", "Gladiador", new List<string> { "Fuerza Ilimitada", "Luchador Agil" }, experiencia: 100, nivel: 5, puntosHabilidad: 10);

			var ClonarPersonaje = (Heroes)personaje.Clone();

			ClonarPersonaje.Personalizar("Optimus", "Transformer");

			Console.WriteLine("Hereo Original:");
			Console.WriteLine(personaje);

			Console.WriteLine("\nHeroe Clonado:");
			Console.WriteLine(ClonarPersonaje);

			ClonarPersonaje.Habilidades.Add("Dispara cohetes");

			Console.WriteLine("\nNuevas Habilidades despues del clonaje:");
			Console.WriteLine("Heroe Original:");
			Console.WriteLine(personaje);

			Console.WriteLine("\nHeroe Clonado:");
			Console.WriteLine(ClonarPersonaje);
		}
	}
}
	
