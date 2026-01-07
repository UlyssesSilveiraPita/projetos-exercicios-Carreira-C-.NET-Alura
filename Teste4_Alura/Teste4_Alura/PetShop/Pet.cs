namespace Teste4_Alura.PetShop;
internal class Pet
{
    public Pet(string nome, int idade, string raca, string sexo)
    {
        Nome = nome;
        Idade = idade;
        Raca = raca;
        Sexo = sexo;
    }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Raca { get; set; }
    public string Sexo { get; set; }
    public Dono DonoPet { get; set; }
    public List<int> ConsultasAgendadas = new List<int>();

    public void Detalhes()
    {
        Console.WriteLine($"{Raca} de nome {Nome}. Responsável: {DonoPet.Nome}");
        Console.WriteLine($"Consultas agendadas: {ConsultasAgendadas.Count}");
    }
}


