using System;
using System.Linq;
using System.Collections.Generic;

namespace CorEscuela.Entidades;

public class Alumno
{
    public string UniqueId { get; set; }
    public string Nombre { get; set; }
    public Curso Curso { get; set; }
    public List<Asignatura> Asignaturas { get; set; }

    public Alumno(string nombre, List<Asignatura> asignaturas)
    {
        UniqueId = Guid.NewGuid().ToString();
        Nombre = nombre;
		Asignaturas = asignaturas;
    }

}
