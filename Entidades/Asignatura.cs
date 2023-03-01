using System;
using System.Linq;
using System.Collections.Generic;

namespace CorEscuela.Entidades;

public class Asignatura : ObjetoEscuelaBase
{
    public int[] Notas { get; set; }

    public Asignatura(string nombre, Evaluaciones evaluaciones)
    {
        Nombre = nombre;
		Notas = evaluaciones.Notas;
    }


}
