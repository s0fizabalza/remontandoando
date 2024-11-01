//Modelar la clase Biblioteca que contenga una lista de objetos Libro y una lista de objetos Socio (que heredan de Persona)
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

public class Prestamo
{
    public Libro Libro { get; set; }
    public Socio Socio { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime? FechaDevolucion { get; set; }
}

//Desarrollar los métodos AgregarLibro(Libro libro), PrestarLibro(Libro libro, Socio socio) y DevolverLibro(Libro libro, Socio socio) para gestionar los préstamos de libros
public class Biblioteca
{
    private List<Libro> libros = new List<Libro>();
    private List<Socio> socios = new List<Socio>();
    private List<Prestamo> prestamos = new List<Prestamo>();

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

    public void PrestarLibro(Libro libro, Socio socio)
    {
        if (!libro.Disponible)
        {
            Console.WriteLine("El libro no está disponible.");
            return;
        }

        libro.Disponible = false;
        Prestamo prestamo = new Prestamo { Libro = libro, Socio = socio, FechaPrestamo = DateTime.Now };
        prestamos.Add(prestamo);
        Console.WriteLine($"El libro '{libro.Titulo}' ha sido prestado a {socio.Nombre} {socio.Apellido}.");
    }

    public void DevolverLibro(Libro libro, Socio socio)
    {
        Prestamo prestamo = prestamos.FirstOrDefault(p => p.Libro == libro && p.Socio == socio);
        if (prestamo == null)
        {
            Console.WriteLine("No se encontró un préstamo para este libro y socio.");
            return;
        }

        libro.Disponible = true;
        prestamo.FechaDevolucion = DateTime.Now;
        Console.WriteLine($"El libro '{libro.Titulo}' ha sido devuelto por {socio.Nombre} {socio.Apellido}.");
    }
}