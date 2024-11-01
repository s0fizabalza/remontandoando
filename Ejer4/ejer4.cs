public class Casa
{
    public int Capacidad { get; set; }
    public string ColorExterior { get; set; }

    // Constructor
    public Casa(int capacidad, string colorExterior)
    {
        Capacidad = capacidad;
        ColorExterior = colorExterior;
    }
}