namespace Teste4_Alura.ExercicioOO;

internal class Interno : Funcionario
{
    public decimal salario {  get; set; }

    public Interno(string nome, string cargo, decimal salario) : base (nome, cargo)
    {
        this.salario = salario;
    }

}
