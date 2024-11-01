public class CarritoDeCompras //Modelar la clase CarritoDeCompras que contenga una lista de objetos Producto.

{
    private List<Producto> productos = new List<Producto>();

    // Método para agregar un producto al carrito
    public void AgregarProducto(Producto producto)
    {
        productos.Add(producto);   

    }
}