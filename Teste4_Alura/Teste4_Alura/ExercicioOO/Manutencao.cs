namespace Teste4_Alura.ExercicioOO;

internal class Manutencao : IServico
{
    string tipoServico = string.Empty;

    public Manutencao(string tipoServico, Funcionario2 funcionario2)
    {
        this.tipoServico = tipoServico;
        Funcionario2 = funcionario2;
    }

    public Funcionario2 Funcionario2 {  get; set; }    

    public void ExcecutarServico()
    {
        Console.WriteLine($"""
            Executando servico de manutencao: {tipoServico}
            Responsavel: {Funcionario2.Nome} - Departamento: {Funcionario2.Departamento}

            """);
    }
}
