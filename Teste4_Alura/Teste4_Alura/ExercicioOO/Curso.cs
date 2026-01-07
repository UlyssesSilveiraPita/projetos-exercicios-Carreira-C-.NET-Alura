using System.Collections.Concurrent;

namespace Teste4_Alura.ExercicioOO;

internal class Curso
{
    public int vagasTotais;
    public string nome { get; set; }
    private List<string> matriculas = new List<string>();    
    public int vagasDisponiveis { get;}

    public Curso(string nome, int vagasTotais)
    {
        this.nome = nome;
        this.vagasTotais = vagasTotais;
    }

    public bool Matricular(Estudante2 estudante)
    {

        if(vagasTotais  != 0)
        {
            Console.WriteLine("Estudante Matriculado com Sucesso");
            matriculas.Add(estudante.Nome);
            vagasTotais -= 1;
            return true;
        }
        else
        {
            Console.WriteLine("Erro: Não há vagas disponíveis para este curso.");

            return false;
        }


    }
    public void ListarMatriculados()
    {
        Console.WriteLine($"\nEstudantes matriculados em logica de programacao:");

        foreach(var matriculas in matriculas)
        {
            Console.WriteLine($"- {matriculas.ToString()}");
        }

        Console.WriteLine($"Vagas Disponiveis: {vagasTotais}");
    }

}
