class Conta
{
    private Titular titular = new Titular();

    public Titular DadosDoTitular => titular; 

    public string Banco { get; private set; }
    public int Agencia { get; private set; }
    public int NumeroDaConta { get; private set; }
    public int Saldo { get; private set; }
    public int Limite { get; private set; }

    public void DefinirConta(int agencia, int numero, int saldo, int limite)
    {
        Agencia = agencia;
        NumeroDaConta = numero;
        Saldo = saldo;
        Limite = limite;
    }

    public void DefinirTitular(string endereco, int cep, string rua)
    {
        titular.DefinirEndereco(endereco, cep, rua);
    }

  
    public void InformacaoContaTitular()
    {
        this.Agencia = 001;
        this.NumeroDaConta = 180001;
        this.Saldo = 1000;
        this.Limite = 5000;

       
    }
    public string ExibirInformacoes()
    {

        return 
               $"Agência: {Agencia:000}\n" +
               $"Conta: {NumeroDaConta}\n" +
               $"Saldo: {Saldo}\n" +
               $"Limite: {Limite}";
    }
}



