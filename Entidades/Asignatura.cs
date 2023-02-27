using System;
using System.Linq;
using System.Collections.Generic;

namespace CorEscuela.Entidades;

public class Asignatura 
{         
	public string UniqueId { get; set; }
	public string Nombre { get;set; }
	public string NombreCurso { get; set; }
	
	public Asignatura(string nombre, Curso curso)
	{
		UniqueId = Guid.NewGuid().ToString();
		Nombre = nombre;
		NombreCurso = curso.Nombre;
	}
}
