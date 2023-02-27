using System;
using System.Linq;
using System.Collections.Generic;

namespace CorEscuela.Entidades;

public class Escuela
{
	public string UniqueId { get; set; }
	public string Nombre { get; set; }
	public List<Curso> Cursos { get; set; }
	public List<Asignatura> Asignaturas { get; set; }
	public List<Alumno> Alumnos { get; set; }

	public Escuela()
	{
		UniqueId = Guid.NewGuid().ToString();
		Nombre = "Escuela Platzi";
		Cursos = new List<Curso>();
	}

	public void AñadirCurso(Curso curso) => Cursos.Add(curso);
}
