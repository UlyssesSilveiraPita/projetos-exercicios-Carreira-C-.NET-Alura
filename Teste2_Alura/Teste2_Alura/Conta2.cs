class Conta2
{

    public Titular2 Titular2 { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular2.Nome} - Saldo: {this.Saldo} - Limite: {this.Limite}";

    public Conta2(Titular2 titular2, int agencia, int numeroDaConta, double saldo, double limite)
    {
        this.Titular2 = titular2;
        this.Agencia = agencia;
        this.NumeroDaConta = numeroDaConta;
        this.Limite = limite;
        this.Saldo = 5000;
    }


}