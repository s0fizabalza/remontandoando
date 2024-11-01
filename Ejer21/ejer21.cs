public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
}

public class Socio : Persona
{
    public int NumeroSocio { get; set; }
}

public class Libro
{
    public string ISBN { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public bool Disponible { get; set; }
}

public class Biblioteca
{
    private List<Libro> libros = new List<Libro>();
    private List<Socio> socios = new List<Socio>();

    public void AgregarLibro(Libro libro)
    {
        libros.Add(libro);
    }

    public void AgregarSocio(Socio socio)
    {
        socios.Add(socio);
    }

    public Libro BuscarLibroPorISBN(string isbn)
    {
        return libros.FirstOrDefault(libro => libro.ISBN == isbn);
    }

    public Socio BuscarSocioPorNumero(int numeroSocio)
    {
        return socios.FirstOrDefault(socio => socio.NumeroSocio == numeroSocio);
    }
}