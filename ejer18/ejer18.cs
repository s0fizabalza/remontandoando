
//Desarrollar los métodos AgregarProducto(Producto producto), EliminarProducto(Producto producto)
//y VaciarCarrito() para gestionar los productos en el carrito

public class CarritoDeCompras
{
    private List<Producto> productos = new List<Producto>();

    public void AgregarProducto(Producto producto)
    {
        productos.Add(producto);
        Console.WriteLine($"Se ha agregado {producto.Nombre} al carrito.");
    }
    public void EliminarProducto(Producto producto)
    {
        if (productos.Contains(producto))
        {
            productos.Remove(producto);
            Console.WriteLine($"Se ha eliminado {producto.Nombre} del carrito.");
        }
        else
        {
            Console.WriteLine($"El producto {producto.Nombre} no se encuentra en el carrito.");
        }
    }

    public void VaciarCarrito()
    {
        productos.Clear();
        Console.WriteLine("El carrito ha sido vaciado.");
    }

    public decimal CalcularTotal() //Desarrollar el método CalcularTotal() que calcule y devuelva el precio total de los productos en el carrito.
    {
        decimal total = 0;
        foreach (Producto producto in productos)
        {
            total += producto.Precio * producto.Cantidad;
        }
        return total;
    }
}