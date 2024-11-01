public class Casa
{
    public int Capacidad { get; set; }
    public string ColorExterior { get; set; }
    public List<Persona> Habitantes { get; set; } = new List<Persona>();

    public Casa(int capacidad, string colorExterior)
    {
        Capacidad = capacidad;
        ColorExterior = colorExterior;
    }

    public void PresentarMayoresDeEdad()
    {
        Console.WriteLine("Habitantes mayores de edad:");

        foreach (Persona habitante in Habitantes)
        {
            if (habitante.EsMayorDeEdad())
            {
                habitante.Presentarse();
            }
        }
    }
}