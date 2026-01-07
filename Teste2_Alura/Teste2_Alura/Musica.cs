class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    // propriedade somente de leitura com manipulacao
    public string DescricaoResumida
    {
        get
        {
            return $"A musica {Nome} pertence a banda {Artista}";
        }

    }

    // exemplo acima escrito de forma mais utilizada como lambida

    public string DescricaoResumida1 => $"A musica {Nome} pertence a banda {Artista}"; // forma lambida

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"O nome da Musica é: {Nome} - {Artista} ");
        Console.WriteLine($"O nome do Artista é: {Artista}");
    }

    public void Teste()
    {
        //===========Exemplo de utilizacao de lambida em outros casos ===============\\
       
        /*
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        List<int> numerosPares = numeros.FindAll(BuscarNumerosQueSaoPares);

        bool BuscarNumerosQueSaoPares(int numero)
        {
            return numero % 2 == 0;
        }

        foreach (int numero in numerosPares)
        {
            Console.WriteLine(numero);
        }
        */
    

        //==== re escrevendo o codigo utilizando funcao lambida =====\\

        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
        numerosPares.ForEach(numero => Console.WriteLine(numero));

    }
}





