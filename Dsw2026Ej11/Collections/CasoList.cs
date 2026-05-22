using System.Collections.Generic;
using System.Linq;
namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
using System.Collections.Generic;
using System.Linq;




public class Alumno
{
    public required string Nombre { get; set; }
}

public interface ICasoList
{
    void AgregarAlumno(Alumno alumno);
    Alumno? BuscarPorNombre(string nombre); // Se agregó '?'
    void EliminarAlumno(Alumno alumno);
    void EliminarEnPosicion(int posicion);
    List<Alumno> RetornarLista();
}

public interface ICasoList1
{
    void AgregarAlumno(Alumno alumno);
    Alumno? BuscarPorNombre(string nombre);
    void EliminarAlumno(Alumno alumno);
    void EliminarEnPosicion(int posicion);
    List<Alumno> RetornarLista();
}

public interface ICasoList2
{
    void AgregarAlumno(Alumno alumno);
    Alumno? BuscarPorNombre(string nombre); 
    void EliminarAlumno(Alumno alumno);
    void EliminarEnPosicion(int posicion);
    List<Alumno> RetornarLista();
}

public class CasoList : ICasoList, ICasoList1, ICasoList2
{
    private List<Alumno> _alumnos = new List<Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        _alumnos.Add(alumno);
    }

    public List<Alumno> RetornarLista()
    {
        return _alumnos;
    }

    // Se agregó '?' para coincidir con la interfaz y resolver la advertencia de nulos
    public Alumno? BuscarPorNombre(string nombre)
    {
        return _alumnos.FirstOrDefault(a => a.Nombre == nombre);
    }

    public void EliminarAlumno(Alumno alumno)
    {
        _alumnos.Remove(alumno);
    }

    public void EliminarEnPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < _alumnos.Count)
        {
            _alumnos.RemoveAt(posicion);
        }
    }
}