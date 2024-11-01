public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }

    public Persona(string nombre, string apellido, int edad)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;   

    }

    public void Presentarse()
    {
        Console.WriteLine($"Hola, soy {Nombre} {Apellido}");
    }
}


// Crear un objeto Persona
Persona persona1 = new Persona("Juan", "Pérez", 30);

// Llamar al método Presentarse()
persona1.Presentarse(); // Imprimirá: Hola, soy Juan Pérez