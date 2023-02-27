using System;
using System.Linq;
using System.Collections.Generic;

namespace CorEscuela.Entidades;

public class EscuelaEngine 
{         
    public void Inicializar()
	{
		Escuela escuela = new Escuela();
		escuela.AñadirCurso(new Curso("101"));
	}
	
}
