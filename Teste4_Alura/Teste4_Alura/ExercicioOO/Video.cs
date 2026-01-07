namespace Teste4_Alura.ExercicioOO;

internal class Video : Midia
{
    public int Duracao { get; set; }

    public Video(string nome, int duracao) : base(nome)
    {   
        Nome = nome;
        Duracao = duracao;
    }


    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Video: {this.Nome}  - Duracao: {this.Duracao} minutos");
    }
}
