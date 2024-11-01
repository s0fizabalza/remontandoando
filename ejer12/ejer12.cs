public class CuentaBancaria
{
    public Persona Titular { get; set; }
    public decimal Saldo { get; private set; } //modifica con la clase
    

    public CuentaBancaria(Persona titular, decimal saldoInicial)
    {
        Titular = titular;
        Saldo = saldoInicial;
    }

}