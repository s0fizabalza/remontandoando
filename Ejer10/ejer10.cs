public class Persona
{
    public const int MAYORIA_DE_EDAD = 18;

    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }

    public Persona(string nombre, string apellido, int edad)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;   

    }

     public bool MayorDeEdad()
    {
        return Edad >= MAYORIA_DE_EDAD;
    }
}
