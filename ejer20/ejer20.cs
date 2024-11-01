public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
}

public class Estudiante : Persona
{
    public string Carrera { get; set; }
    public double Promedio { get; set; }

    // Constructor
    public Estudiante(string nombre, string apellido, int edad, string carrera, double promedio) : base(nombre, apellido, edad)
    {
        Carrera = carrera;
        Promedio = promedio;
    }

    // Método para actualizar 
    public void ActualizarPromedio(double nuevoPromedio)
    {
        Promedio = nuevoPromedio;
    }
}