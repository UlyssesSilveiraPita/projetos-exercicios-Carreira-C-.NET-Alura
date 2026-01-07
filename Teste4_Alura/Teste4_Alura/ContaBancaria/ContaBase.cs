namespace Teste4_Alura.ContaBancaria;

internal class ContaBase
{
    public int NumeroConta {  get; set; }
    public string Titular { get; set; }
    public double Saldo {  get;  set; }

    public void Depositar (double valorDesositar)
    {
        if(valorDesositar > 0)
        {
            Saldo += valorDesositar;
        }
    }
    public void Sacar(double valorSacar)
    {
        if(valorSacar > 0 && valorSacar <= Saldo)
        {
            Saldo -= valorSacar;
        }
    }

}
