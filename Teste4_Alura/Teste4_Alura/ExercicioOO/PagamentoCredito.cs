namespace Teste4_Alura.ExercicioOO;

internal class PagamentoCredito : Pessoa3, IPagamento
{

    public PagamentoCredito(string nome, string email) : base(nome, email)
    {

    }

    public void ProcessarPagamento()
    {
        Console.WriteLine($"Processando pagamento com cartao de credito para {Nome} - {Email}");
    }
}
