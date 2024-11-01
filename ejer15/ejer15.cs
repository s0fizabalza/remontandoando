public class Producto //Modelar la clase Producto con los atributos nombre, precio y cantidadDisponible.

{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int CantidadDisponible { get; set; }

    public   
 Producto(string nombre, decimal precio, int cantidadDisponible) //Crear un constructor que reciba el nombre, precio y cantidad disponible del producto.

    {
        Nombre = nombre;
        Precio = precio;
        CantidadDisponible = cantidadDisponible;
    }
}