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
}
