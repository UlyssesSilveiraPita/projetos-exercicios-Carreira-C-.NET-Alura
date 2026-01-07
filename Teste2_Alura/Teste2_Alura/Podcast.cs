class Podcast
{
    public Podcast(string nome, string host, int totalEpisodios)
    {
        Nome = nome;
        Host = host;
        TotalEpisodios = totalEpisodios;
    }

    public string Nome { get; private set; }
    public string Host { get; private set; }
    public int TotalEpisodios { get; private set; }

    

    public void AdicionarEpisodios()
    {
        Console.Write("Add um novo Episodio: ");
        string novoEpisodio = Console.ReadLine()!;
        List<string> episodios = new List<string>();    
        episodios.Add(novoEpisodio);
        Console.WriteLine($"Episodio: {novoEpisodio} foi add.");

    }

    public string ExibirDetalhes(string Nome,string Host)
    {
        Nome = "FalaPopular";
        Host = "Didi-Toto";


        string informacaodoPodCast = $"\nVoce esta assistindo ao {Nome} | Apresentando por {Host}";

        List<string> listaEpisodios = new List<string>() {"CucaComeBala","CucaComeDoce", "CucaComeCoco" };

        Console.WriteLine(informacaodoPodCast);
        int index = 0;

        foreach (string episodios in listaEpisodios)
        {
            index++;
            Console.WriteLine($"Episodio n': {index} | Episodio: {episodios}");
            
        }
        TotalEpisodios = listaEpisodios.Count;
        Console.WriteLine($"Total de Episidios: {TotalEpisodios}");

        return informacaodoPodCast;
    }


}