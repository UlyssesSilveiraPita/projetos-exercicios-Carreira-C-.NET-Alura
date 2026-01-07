namespace Teste4_Alura.ExercicioOO;

internal class Funcionario3
{
    public string Nome { get; set; }
    private double Salario { get; set; }
    public Funcionario3(string nome, double salario)
    {
        Nome = nome;
        Salario = salario;
    }

    public void ReajustSalario(double novoSalario)
    {
        if(novoSalario < Salario) { Console.WriteLine("Erro: O novo Salario deve ser maior que o atual"); }
        else 
        {
            Console.WriteLine($""""
            Funcionario: {Nome}
            Salario atual: {novoSalario:c2}
            """");
        }
    }
    
}
