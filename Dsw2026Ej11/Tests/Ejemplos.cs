using System;
using Dsw2026Ej11.Collections;

namespace Dsw2026Ej11.Tests;

public class Ejemplos
{
    public static void EjemploDictionary()
    {
        Console.WriteLine("--- EJEMPLO DICTIONARY ---");

        CasoDictionary miDiccionario = new CasoDictionary();
        miDiccionario.AgregarAlumno(101, new Alumno { Nombre = "Gonzalo" });
        miDiccionario.AgregarAlumno(102, new Alumno { Nombre = "María" });
        miDiccionario.AgregarAlumno(103, new Alumno { Nombre = "Pedro" });
        Console.WriteLine("Alumnos agregados correctamente.");

        int legajoABuscar = 101;
        Alumno? alumnoBuscado = miDiccionario.BuscarPorClave(legajoABuscar);

        if (alumnoBuscado != null)
        {
            Console.WriteLine($"\nAlumno encontrado (Legajo {legajoABuscar}): {alumnoBuscado.Nombre}");
        }

        miDiccionario.EliminarPorClave(102);
        Console.WriteLine("\nEl alumno con legajo 102 fue eliminado.");
    }

    public static void EjemploList()
    {
        Console.WriteLine("--- EJEMPLO LIST ---");

        CasoList miLista = new CasoList();

        miLista.AgregarAlumno(new Alumno { Nombre = "Gonzalo" });
        miLista.AgregarAlumno(new Alumno { Nombre = "María" });

        Console.WriteLine("Alumnos agregados correctamente.");

        string nombreABuscar = "Gonzalo";
        Alumno? alumnoBuscado = miLista.BuscarPorNombre(nombreABuscar);

        if (alumnoBuscado != null)
        {
            Console.WriteLine($"\nAlumno encontrado: {alumnoBuscado.Nombre}");
        }

        miLista.EliminarEnPosicion(1);
        Console.WriteLine("\nEl alumno en posición 1 fue eliminado.");
    }

    public static void EjemploLinq()
    {
        Console.WriteLine("--- EJEMPLO LINQ ---");

        CasoLinq miCasoLinq = new CasoLinq();

        miCasoLinq.AgregarLibro(new Libro { Id = 10, Titulo = "El Señor de los Anillos", Precio = 25000m });
        miCasoLinq.AgregarLibro(new Libro { Id = 18, Titulo = "Cien Años de Soledad", Precio = 15000m });
        miCasoLinq.AgregarLibro(new Libro { Id = 22, Titulo = "1984", Precio = 12000m });
        miCasoLinq.AgregarLibro(new Libro { Id = 5, Titulo = "Hábitos Atómicos", Precio = 18000m });

        Console.WriteLine("Libros de prueba agregados.\n");

        Console.WriteLine($"1. Primer libro: {miCasoLinq.GetPrimero()?.Titulo}");
        Console.WriteLine($"2. Último libro: {miCasoLinq.GetUltimo()?.Titulo}");
        Console.WriteLine($"3. Suma total de precios: {miCasoLinq.GetTotalPrecios():C}");
        Console.WriteLine($"4. Promedio de precios: {miCasoLinq.GetPromedioPrecios():C}\n");

        Console.WriteLine("5. Libros con ID mayor a 15:");
        foreach (var libro in miCasoLinq.GetListById())
        {
            Console.WriteLine($"   - {libro.Titulo} (ID: {libro.Id})");
        }

        Console.WriteLine("\n6. Lista en formato Título - Precio:");
        foreach (var texto in miCasoLinq.GetLibros())
        {
            Console.WriteLine($"   - {texto}");
        }

        Console.WriteLine($"\n7. Libro más caro: {miCasoLinq.GetMayorPrecio()?.Titulo} ({miCasoLinq.GetMayorPrecio()?.Precio:C})");
        Console.WriteLine($"8. Libro más barato: {miCasoLinq.GetMenorPrecio()?.Titulo} ({miCasoLinq.GetMenorPrecio()?.Precio:C})\n");

        Console.WriteLine("9. Libros con precio mayor al promedio:");
        foreach (var libro in miCasoLinq.GetMayorPromedio())
        {
            Console.WriteLine($"   - {libro.Titulo} ({libro.Precio:C})");
        }

        Console.WriteLine("\n10. Libros ordenados alfabéticamente al revés (Z-A):");
        foreach (var libro in miCasoLinq.GetOrdenadosDescendente())
        {
            Console.WriteLine($"   - {libro.Titulo}");
        }
    }
}