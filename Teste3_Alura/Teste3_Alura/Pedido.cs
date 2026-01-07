class Pedido
{
    public string NumeroPedido;
    public string NomeCliente;
    public string Status;

    public Pedido(string numeroPedido, string nomeCliente, string status)
    {
        NumeroPedido = numeroPedido;
        NomeCliente = nomeCliente;
        Status = status;
    }

    public void AtualizarStatus(string novoStatus)
    {
        Status = novoStatus;    
    }

    public void ExibirPedido()
    {
        Console.WriteLine($""""
            Pedido n'{NumeroPedido}
            Cliente: {NomeCliente}
            Status: {Status}

            """");
    }
}