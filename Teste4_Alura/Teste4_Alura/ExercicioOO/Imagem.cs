namespace Teste4_Alura.ExercicioOO;

internal class Imagem : Midia
{
    public string Resolucao { get; set; }

    public Imagem(string nome , string resolucao) : base(nome) 
    {
        Nome = nome;
        Resolucao = resolucao;
    }


    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Imagem: {this.Nome} - Resolucao: {this.Resolucao}");
    }
    
}
