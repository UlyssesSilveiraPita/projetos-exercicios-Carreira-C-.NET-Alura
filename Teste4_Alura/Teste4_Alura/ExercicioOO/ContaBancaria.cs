namespace Teste4_Alura.ExercicioOO;

internal class ContaBancaria
{
    SegurancaConta seguranca = new SegurancaConta();

    public string Titular {  get; set; }
    public double Saldo { get;}

    public ContaBancaria(string titular, double saldo)
    {
        Titular = titular;
        this.Saldo = saldo;
    }

    public double Sacar (double saldo)
    {
       double saldoAtual = Saldo - saldo;

       if(seguranca.ValidarSaque(saldo) == true)
       {
            Console.WriteLine($"""
                Nome: {Titular}
                Saque realizado com Sucesso
                "Saldo atual: {saldoAtual:c2}
                """);

            
       }

        if (seguranca.ValidarSaque(saldo) == false)
        {
            Console.WriteLine("Saque negado pela Politica de seguranca");
        }

       return saldoAtual;

    }

   
}
