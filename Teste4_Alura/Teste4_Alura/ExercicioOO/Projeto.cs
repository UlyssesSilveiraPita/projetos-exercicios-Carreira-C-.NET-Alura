namespace Teste4_Alura.ExercicioOO;

internal class Projeto
{
    public string Nome {  get; set; }
    private List<string> tarefas = new List<string> { };

    public Projeto(string nome)
    {
        Nome = nome;
    }

    public List<string> AdicionarTarefa (string tarefa)
    {
       tarefas.Add(tarefa);

       return tarefas;
    }

    public void ExibirTarefas()
    {
            Console.WriteLine($"""
                Projeto: {Nome}
                Tarefas:
                - {tarefas[0]}
                - {tarefas[1]}
                Total: {tarefas.Count} tarefas
                
                """);
       
        
    }
}
