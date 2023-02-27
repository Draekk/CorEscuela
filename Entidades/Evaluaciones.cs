using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorEscuela.Entidades
{
    public class Evaluaciones
    {
        public int[] Notas { get; set; }
        public Evaluaciones(int[] notas)
        {
            Notas = notas;
        }
    }
}