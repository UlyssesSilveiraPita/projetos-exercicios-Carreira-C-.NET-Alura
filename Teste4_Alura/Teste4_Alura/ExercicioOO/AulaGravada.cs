namespace Teste4_Alura.ExercicioOO;

internal class AulaGravada : Conteudo
{
    public AulaGravada(string titulo, int duracao) : base(titulo)
    {
        Duracao = duracao;
    }

    public int Duracao { get; set; }

    public override void ExibirInfo()
    {
        Console.WriteLine($""""
            Titulo: {Titulo}
            Duracao: {Duracao} min
            """");
    }
}
