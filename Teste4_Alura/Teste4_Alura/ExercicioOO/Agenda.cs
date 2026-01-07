namespace Teste4_Alura.ExercicioOO;

internal class Agenda
{

    public string Proprietario { get; set; }
    private List<Contato> contatos { get; }
    public int QuantContatos => contatos.Count;


    public Agenda(string proprietario)
    {
        Proprietario = proprietario;
        contatos = new List<Contato>();
    }

    public bool AdicionarContato(Contato contato)
    {
        bool jaExiste = contatos.Any(nome => nome.Nome == contato.Nome);

        if (jaExiste)
        {
            Console.WriteLine("Contato com esse nome já está na agenda.");
            return false;
        }
        else
        {
            contatos.Add(contato);
            return true;

        }

    }

    public void ListarContatos()
    {

        Console.WriteLine($"Agenda de: {Proprietario}");
        foreach (Contato contato in contatos)
        {
            Console.WriteLine($" - Contatos: {contato.Nome} | {contato.Telefone}");
        }
       
        Console.WriteLine($"Total de Contato: {QuantContatos}");
    }
}
