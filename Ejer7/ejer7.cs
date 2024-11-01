public class Casa
{
    public int Capacidad { get; set; }
    public string ColorExterior { get; set; }

    public Casa(int capacidad, string colorExterior)
    {
        Capacidad = capacidad;
        ColorExterior = colorExterior;
    }

    public void PresentarHabitantes()
    {
        Console.WriteLine($"Los habitantes de esta casa son:");
        foreach (Persona habitante in Habitantes)
        {
            habitante.Presentarse();
        }
    }
}


