using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clonar_PersonajesV1
{
	internal class Heroes : ICloneable
	{
		public string Nombre { get; set; }
		public string ClaseHeroe { get; set; }
		public List<string> Habilidades { get; set; }
		public int Experiencia { get; set; }
		public int Nivel { get; set; }
		public int PuntosHabilidad { get; set; }

		
		public Heroes(string nombre, string claseHeroe, List<string> habilidades, int experiencia = 0, int nivel = 1, int puntosHabilidad = 0)
		{
			Nombre = nombre;
			ClaseHeroe = claseHeroe;
			Habilidades = new List<string>(habilidades); 
			Experiencia = experiencia;
			Nivel= nivel;
			PuntosHabilidad = puntosHabilidad;
		}

		// Método para clonar el héroe
		public object Clone()
		{
			// Realiza una clonación profunda
			return new Heroes(Nombre, ClaseHeroe, new List<string>(Habilidades), Experiencia, Nivel, PuntosHabilidad);
		}

		public void Personalizar(string nuevoNombre, string nuevaApariencia)
		{
			Nombre = nuevoNombre;
			Console.WriteLine($"Hereo {Nombre}  Nueva Apariencia o Aspecto: {nuevaApariencia}");
		}

		// Método para mostrar detalles del héroe
		public override string ToString()
		{
			return $"{Nombre} ({ClaseHeroe}) - Nivel: {Nivel}, Experiencia: {Experiencia}, PuntosHabilidad: {PuntosHabilidad}, Habilidades: {string.Join(", ", Habilidades)}";
		}
	}

}

