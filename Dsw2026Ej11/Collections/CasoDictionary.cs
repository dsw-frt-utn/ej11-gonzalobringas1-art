namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave


using System;
using System.Collections.Generic;

public class CasoDictionary
{
   
    private Dictionary<int, Alumno> _diccionario = new Dictionary<int, Alumno>();

   
    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        
        _diccionario.TryAdd(legajo, alumno);
    }

   
    public Alumno? BuscarPorClave(int legajo)
    {
        
        if (_diccionario.TryGetValue(legajo, out Alumno? alumnoEncontrado))
        {
            return alumnoEncontrado;
        }
        return null; 
    }

    
    public Dictionary<int, Alumno> RetornarDiccionario()
    {
        return _diccionario;
    }

    
    public void EliminarPorClave(int legajo)
    {
        
        _diccionario.Remove(legajo);
    }
}