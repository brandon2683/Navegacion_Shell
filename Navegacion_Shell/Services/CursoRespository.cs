using Navegacion_Shell.Models;

namespace Navegacion_Shell.Services;

public static class CursoRepository
{
    public static List<Curso> Cursos { get; } = new()
    {
        new Curso { Id = 1, Nombre = "Matemáticas",   Descripcion = "Álgebra, cálculo y geometría", Instructor = "Prof. García" },
        new Curso { Id = 2, Nombre = "Historia",      Descripcion = "Historia universal contemporánea", Instructor = "Prof. López" },
        new Curso { Id = 3, Nombre = "Ciencias",      Descripcion = "Física y química básica", Instructor = "Prof. Ramírez" },
        new Curso { Id = 4, Nombre = "Programación",  Descripcion = "Desarrollo con C# y .NET MAUI", Instructor = "Prof. Torres" },
        new Curso { Id = 5, Nombre = "Idiomas",       Descripcion = "Inglés avanzado B2-C1", Instructor = "Prof. Méndez" }
    };

    public static Curso? GetById(int id) => Cursos.FirstOrDefault(c => c.Id == id);
}