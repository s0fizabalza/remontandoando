using System.Collections.Generic;

public class Casa
{
    public int Capacidad { get; set; }
    public string ColorExterior { get; set; }
    public List<Persona> Habitantes { get; set; }

    public Casa(int capacidad, string colorExterior)
    {
        Capacidad = capacidad;
        ColorExterior = colorExterior;
        Habitantes = new List<Persona>(); 
    }

    
    public void AgregarHabitante(Persona persona)
    {
        Habitantes.Add(persona);
    }
}

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    // Constructor
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;   

    }
}