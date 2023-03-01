using System;
using System.Linq;
using System.Collections.Generic;

namespace CorEscuela.Entidades;

public class Alumno : ObjetoEscuelaBase
{
    public List<Asignatura> Asignaturas { get; set; }

    public Alumno(string nombre, List<Asignatura> asignaturas)
    {
        Nombre = nombre;
		Asignaturas = asignaturas;
    }

}
