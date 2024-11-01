public class Direccion
{
    public string Calle { get; set; }
    public int Altura { get; set; }
    public string Ciudad { get; set; }
    public string Barrio { get; set; }

    // Constructor
    public Direccion(string calle, int altura, string ciudad, string barrio)
    {
        Calle = calle;
        Altura = altura;
        Ciudad = ciudad;
        Barrio = barrio;
    }
}