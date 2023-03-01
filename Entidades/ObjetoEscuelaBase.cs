using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorEscuela.Entidades
{
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueId { get; set; } = Guid.NewGuid().ToString();
        public string Nombre { get; set; }

    }
}