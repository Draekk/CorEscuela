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

    public List<Alumno> InscripcionMasivaAlumnos(int cantidad)
    {
        string[] nombre = { "Gever", "Laura", "Yudith", "José", "Christopher", "Carmen" };
        string[] apellido = { "Rodríguez", "Peña", "Peralta", "Arias", "Colina", "Flores" };

        var alumnos = from n in nombre
                      from a in apellido
                      select new Alumno($"{n} {a}");
        return alumnos.OrderBy((al) => al.UniqueId).Take(cantidad).ToList();
    }

    public void AñadirCurso(Curso curso) => Cursos.Add(curso);

    public override string ToString()
    {
        if (Cursos.Count > 0)
        {
            string c = "";
            foreach (var curso in Cursos)
            {
                c += $"Curso {curso.Nombre}...";
                if (curso.Alumnos.Count > 0)
                {
                    string a = $"\nAlumnos:";
                    foreach (var alumno in curso.Alumnos)
                    {
                        a += $"\n{alumno.Nombre}";
                    }
                    c += $"{a}.\n\n";
                }
            }
            return $"Nombre: {Nombre}\n\nCursos:\n{c}";
        }
        return $"Nombre: {Nombre}";
    }
}
