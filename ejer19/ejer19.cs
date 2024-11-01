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