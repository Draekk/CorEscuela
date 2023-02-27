using System;
using System.Linq;
using System.Collections.Generic;

namespace CorEscuela.Entidades;

public class Alumno
{
	public string UniqueId { get; set; }
	public string Nombre { get; set; }
	public Curso Curso { get; set; }

	public Alumno(string nombre, Curso curso)
	{
		UniqueId = Guid.NewGuid().ToString();
		Nombre = nombre;
		Curso = curso;
	}

}
