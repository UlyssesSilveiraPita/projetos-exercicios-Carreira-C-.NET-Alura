namespace Teste4_Alura.ExercicioOO;

internal class Avaliacao
{
    public string Aluno { get; set; }
    public int Nota { get; private set; }

    public Avaliacao(string aluno)
    {
        Aluno = aluno;
    }


    public void AtribuirNota(double nota)
    {
        if (nota < 0 || nota > 10) { Console.WriteLine("Erro: A nota deve ser entre 0 e 10."); }
        else
        {
            Console.WriteLine($""""
                Aluno: {Aluno}
                nota atribuida: {nota}

                """");
        }
 
    }



}
