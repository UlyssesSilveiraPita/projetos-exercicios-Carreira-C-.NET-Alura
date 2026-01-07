class Produto
{
    public Produto(string nome, int quantidadeInicial)
    {
        Nome = nome;
        QuantidadeInicial = quantidadeInicial;
    }
    public string Nome { get; set; }
    public int QuantidadeInicial { get; set; } = 20 ;
    private int _quantidadeEstoque;

    public int Retirada(int quantidade)
    {
        Console.Write("Quantos itens deseja Retirar: ");
        quantidade = int.Parse(Console.ReadLine()!);
        _quantidadeEstoque = QuantidadeInicial - quantidade;

        if (quantidade >= QuantidadeInicial)
        {
            Console.WriteLine($"Erro: Estoque insuficiente para a retirada de {quantidade} unidades.");
            _quantidadeEstoque = QuantidadeInicial;
        }
        else
        {
            Console.WriteLine($""""

                Retirada de {quantidade} realizada com sucesso.
                Produto: {Nome}
                Estoque: {QuantidadeInicial}
                """");

        }
            Console.Write("A quantidade Atual do Estoque é: ");
        
            return _quantidadeEstoque;
    }

}