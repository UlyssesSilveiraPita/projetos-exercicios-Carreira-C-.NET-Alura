class ProdutoDigital
{
    public String Nome;
    public double Preco;
    public InformacaoTecnica InfoTecnica;

    public ProdutoDigital(string nome, double preco, InformacaoTecnica infoTecnica)
    {
        Nome = nome;
        Preco = preco;
        InfoTecnica = infoTecnica;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($""""
            Produto: {Nome}
            Preco: {Preco:c}
            Tamanho: {InfoTecnica.TamanhoMB}MB
            Compativel com: {InfoTecnica.SistemaOperacional}

            """");
    }

}