class ContaBancaria
{

    //public int Somar(int a, int b)
    //{
    //    int resultado = a + b;
    //    return resultado;
    //}

    public int Somar(int a, int b) => a + b;



    public int NumeroIndicador { get; set; }  = 001 ;
    public int Saldo { get; set; } = 5000;
    public int Senha { get; set; } = 000;
    public string Titular { get; set; } = "Ulysses";

    public void Conta()
    {
        Console.WriteLine($"Nome do Titular: {Titular}");
        Console.WriteLine($"Seu saldo é: {Saldo}");
    }




}
