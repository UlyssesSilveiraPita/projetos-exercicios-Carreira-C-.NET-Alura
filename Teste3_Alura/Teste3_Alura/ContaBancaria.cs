class ContaBancaria
{
    public ContaBancaria(string numeroConta, float saldo)
    {
        NumeroConta = numeroConta;
        Saldo = saldo;
        
    }

    public string NumeroConta { get; private set; }
    public float Saldo { get; private set;}



    public void InformacoesConta ()
    {
        NumeroConta = "78901-2";
        Saldo = 1000.00f;
    
        Console.WriteLine($""""
            
            ContaBancaria: {NumeroConta}
            Saldo atua: {SaldoAtualizado():c} 
         
            """");


    }

    public double Depositar(double valor)
    {
        Console.WriteLine("Digite o valor que deseja Depositar: ");
        float depositarValor = float.Parse(Console.ReadLine()!);
        valor = depositarValor;
        return valor;
    }

    public double SaldoAtualizado()
    {
        double saldoAtual = Saldo + Depositar(0);
        return saldoAtual;

    }
}