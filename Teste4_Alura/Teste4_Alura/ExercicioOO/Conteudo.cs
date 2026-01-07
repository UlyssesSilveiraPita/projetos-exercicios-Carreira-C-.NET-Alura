namespace Teste4_Alura.ExercicioOO;

internal class Conteudo
{
    public string Titulo { get; set; }
    public Conteudo(string titulo)
    {
        Titulo = titulo;
    }


    public virtual void ExibirInfo()
    {

    }
}
