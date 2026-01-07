class Titular
{
    public string NomeTitular => "Ulysses Silveira";
    public string Endereco { get; private set; }
    public int Cep { get; private set; }
    public string Rua { get; private set; }

    public void DefinirEndereco(string endereco, int cep, string rua)
    {

        Endereco = "Vila Velha";
        Cep = 45990214;
        Rua = "Rua das Feras";

    }

    public string ExibirTitular =>
        $"{NomeTitular} | {Endereco} | {Cep} | {Rua}";

}


