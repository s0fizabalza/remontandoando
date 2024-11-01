//Pepempleado heredero de Pepersona 
public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
}

public class Empleado : Persona
{
    public string Puesto { get; set; }
    public decimal Salario { get; set; }
}

// Constructor para inicializar todos los atributos
    public Empleado(string nombre, string apellido, int edad, string puesto, decimal salario) : base(nombre, apellido, edad)
    {
        Puesto = puesto;
        Salario = salario;
    }

    // Método para aumentar el salario según un porcentaje
    public void AumentarSalario(decimal porcentaje)
    {
        Salario += Salario * (porcentaje / 100);
    }