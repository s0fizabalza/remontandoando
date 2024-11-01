public class CuentaBancaria
{
    public Persona Titular { get; set; }
    public decimal Saldo { get; private set; }

    public CuentaBancaria(Persona titular, decimal saldoInicial)
    {
        if (titular == null)
        {
            throw new ArgumentNullException(nameof(titular), "El titular no puede ser nulo.");
        }

        if (saldoInicial < 0)
        {
            throw new ArgumentException("El saldo inicial no puede ser negativo.");
        }

        Titular = titular;
        Saldo = saldoInicial;
    }

    public void IngresarDinero(decimal cantidad)
    {
        if (cantidad > 0)
        {
            Saldo += cantidad;
            Console.WriteLine($"Se han ingresado ${cantidad} a la cuenta de {Titular.Nombre}");
        }
        else
        {
            Console.WriteLine("La cantidad a ingresar debe ser positiva.");
        }
    }

    public bool RetirarDinero(decimal cantidad)
    {
        if (cantidad > 0 && Saldo >= cantidad)
        {
            Saldo -= cantidad;
            Console.WriteLine($"Se han retirado ${cantidad} de la cuenta de {Titular.Nombre}");
            return true;
        }
        else
        {
            Console.WriteLine("Fondos insuficientes o cantidad inválida.");
            return false;
        }
    }
    public decimal ObtenerSaldo()
    {
        return Saldo;
    }
   
}