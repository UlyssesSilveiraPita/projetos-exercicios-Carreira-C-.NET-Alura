namespace Teste4_Alura.ExercicioOO;

internal class Passageiro : Pessoa2
{
    public Passageiro(string nome, int idade, int quantidadeBilhetes) : base(nome,idade)
    {
        QuantidadeBilhetes = quantidadeBilhetes;
    }

    public int QuantidadeBilhetes {  get; set; }

    public void ExibirInformacoes(string nome, int idade, int quantidadeBilhetes)
    {
        Console.WriteLine($"Passageiro: {nome} - Idade: {idade} - Bilhestes: {quantidadeBilhetes}");
        
    }
}
