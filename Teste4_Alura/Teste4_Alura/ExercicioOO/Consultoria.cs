namespace Teste4_Alura.ExercicioOO;

internal class Consultoria : IServico
{
    string tipoTarefa = string.Empty;

    public Consultoria(string tipoTarefa, Funcionario2 funcionario2)
    {
        this.tipoTarefa = tipoTarefa;
        Funcionario2 = funcionario2;
    }

    public Funcionario2 Funcionario2 {  get; set; }



    public void ExcecutarServico()
    {
        //Funcionario2 = new Funcionario2(Funcionario2.Nome,Funcionario2.Departamento);

        Console.WriteLine($"""
            Executando servico de Consultoria: {tipoTarefa}
            Responsavel: {Funcionario2.Nome} - Departamento: {Funcionario2.Departamento}

            """);

    }
}
