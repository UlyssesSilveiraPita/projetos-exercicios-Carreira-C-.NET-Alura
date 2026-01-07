
class Episodio
{
    public Episodio(string titulo, int ordem, int duracao, string resumo)
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
        Resumo = resumo;
    }

    //Propriedades
    public int Duracao { get; private set; }
    public int Ordem { get; private set; }
    public string Titulo { get; private set; }
    public string Resumo { get; private set; }

    public string Informacoes => $"Episodios: {Titulo} | n': {Ordem} | Duracao: {Duracao} min | Resumo: {Resumo} " ;


    //Metodo para addConvidados
    public void AdicionarConvidados()
    {
        Console.Write("Add um Convidado: ");
        string nomeConvidado = Console.ReadLine()!;

        List<string> convidado = new List<string>();
        convidado.Add(nomeConvidado);


        // Mostra lista de Convidados add.
        foreach(string nomeConvidados in convidado)
        {
            Console.WriteLine($"Convidado Add:{nomeConvidado}");
        }

    }


}