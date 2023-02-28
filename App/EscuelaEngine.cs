using System;
using System.Linq;
using System.Collections.Generic;

namespace CorEscuela.Entidades;

public class EscuelaEngine 
{         
    public void Inicializar()
	{
		Escuela escuela = new Escuela();
		escuela.AñadirCurso(new Curso("101", escuela.InscripcionMasivaAlumnos(new Random().Next(4,7))));
		escuela.AñadirCurso(new Curso("201", escuela.InscripcionMasivaAlumnos(new Random().Next(4,7))));
		escuela.AñadirCurso(new Curso("301", escuela.InscripcionMasivaAlumnos(new Random().Next(4,7))));
		System.Console.WriteLine(escuela.ToString());
	}

	
}
