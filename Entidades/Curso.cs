using System;
using System.Linq;
using System.Collections.Generic;

namespace CorEscuela.Entidades;

public class Curso
{
	public string UniqueId { get; set; }
	public string Nombre { get; set; }
	public List<Asignatura> Asignaturas { get; set; }
	public List<Alumno> Alumnos { get; set; }

	public Curso(string nombre)
	{
		UniqueId = Guid.NewGuid().ToString();
		Nombre = nombre;
		Asignaturas = new List<Asignatura>();
		Alumnos = new List<Alumno>();
	}

}
