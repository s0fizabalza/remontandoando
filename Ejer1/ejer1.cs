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


Persona persona1 = new Persona("Juan", "Pérez", 30);


persona1.Presentarse(); 