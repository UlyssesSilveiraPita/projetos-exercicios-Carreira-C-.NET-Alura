namespace Teste4_Alura.ExercicioOO;

class ClienteVIP : Pessoa
{
    public string nFidelidade { get; set; }
    public string cVIP { get; set; }

    public ClienteVIP(string nome, int idade, string nFidelidade, string cVIP) : base(nome, idade)   
    {
        this.cVIP = cVIP;
        this.nFidelidade = nFidelidade; 
    }
}
