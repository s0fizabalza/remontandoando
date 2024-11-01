//Desarrollar los métodos AjustarPrecio(decimal nuevoPrecio) y AjustarCantidadDisponible(int nuevaCantidad) 
//que permitan modificar el precio y la cantidad disponible, respectivamente.
public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; private set; } 
    public int CantidadDisponible { get; private set; }

    public Producto(string nombre, decimal precio, int cantidadDisponible)
    {
        Nombre = nombre;
        Precio = precio;
        CantidadDisponible = cantidadDisponible;
    }

    public void AjustarPrecio(decimal nuevoPrecio)
    {
        if (nuevoPrecio >= 0)
        {
            Precio = nuevoPrecio;
            Console.WriteLine($"El precio del producto {Nombre} se ha ajustado a ${nuevoPrecio}");
        }
        else
        {
            Console.WriteLine("El precio no puede ser negativo.");
        }
    }

    public void AjustarCantidadDisponible(int nuevaCantidad)
    {
        if (nuevaCantidad >= 0)
        {
            CantidadDisponible = nuevaCantidad;
            Console.WriteLine($"La cantidad disponible del producto {Nombre} se ha ajustado a {nuevaCantidad}");
        }
        else
        {
            Console.WriteLine("La cantidad disponible no puede ser negativa.");
        }
    }

    public void MostrarInformacion() //Desarrollar el método MostrarInformacion() que imprima en consola el nombre, precio y cantidad disponible del producto.
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Precio: ${Precio}");
        Console.WriteLine($"Cantidad disponible: {CantidadDisponible}");
    }
}