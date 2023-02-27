using System;
using System.Linq;
using System.Collections.Generic;

namespace CorEscuela.Entidades;

public class Asignatura
{
    public string UniqueId { get; set; }
    public string Nombre { get; set; }
    public int[] Notas { get; set; }

    public Asignatura(string nombre, Evaluaciones evaluaciones)
    {
        UniqueId = Guid.NewGuid().ToString();
        Nombre = nombre;
		Notas = evaluaciones.Notas;
    }


}
