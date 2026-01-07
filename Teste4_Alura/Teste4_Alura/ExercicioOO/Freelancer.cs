namespace Teste4_Alura.ExercicioOO;

class Freelancer : Funcionario
{
    public decimal valorProjeto {  get; set; }

    public Freelancer(string nome, string cargo, decimal valorProjeto) : base(nome,cargo) 
    {
        this.valorProjeto = valorProjeto;
    }

}
