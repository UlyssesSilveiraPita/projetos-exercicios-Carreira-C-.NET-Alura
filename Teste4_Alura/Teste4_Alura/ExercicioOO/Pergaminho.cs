namespace Teste4_Alura.ExercicioOO;

internal class Pergaminho : ItemDigital
{
    public string atributoPergaminho;

    public Pergaminho(string nomeItem, string atributoPergaminho)  : base(nomeItem)
    {
        this.atributoPergaminho = atributoPergaminho;
    }

    public void MostrarDetalhes()
    {
        Console.WriteLine($""""
            Detalhes do Pergaminho:

            Titulo: {nomeItem}

            Descricao: {atributoPergaminho}  


            """");
    }
}
