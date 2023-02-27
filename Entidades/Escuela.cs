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
                      select new Alumno($"{n} {a}", ListaAsignaturas(new string[] { "Castellano", "Inglés", "Matemáticas", "Física" }));
        return alumnos.OrderBy((al) => al.UniqueId).Take(cantidad).ToList();
    }

    public List<Asignatura> ListaAsignaturas(string[] nombres)
    {
        List<Asignatura> asignaturas = new List<Asignatura>();
        foreach (var n in nombres)
        {
            asignaturas.Add(new Asignatura(n, new Evaluaciones(GenerarNotas())));
        }
        return asignaturas;
    }

    public int[] GenerarNotas()
    {
        Random rnd = new Random();
        int[] notas = new int[3];
        for (int i = 0; i < notas.Length; i++)
        {
            notas[i] = rnd.Next(0, 10);
        }
		return notas;
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
                string a = $"\nAlumnos:";
                foreach (var alumno in curso.Alumnos)
                {
                    string asig = $"\n	Evaluaciones:";
                    foreach (var asignatura in alumno.Asignaturas)
                    {
						string notas = "";
						for(int i = 0; i < asignatura.Notas.Length; i++){
							notas += $" {asignatura.Notas[i].ToString()}";
						}
                        asig += $"\n	{asignatura.Nombre}: {notas} Promedio: {asignatura.Notas.Average().ToString("F2")}";
                    }
                    a += $"\n{alumno.Nombre}\n{asig}\n\n";

                }
                c += $"{a}\n\n";
            }
            return $"Nombre: {Nombre}\n\nCursos:\n{c}";
        }
        return $"Nombre: {Nombre}";
    }
}
