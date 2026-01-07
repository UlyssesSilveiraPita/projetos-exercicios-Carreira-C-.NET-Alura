namespace Teste4_Alura.ExercicioOO;

internal class HistoricoMedico
{
    public string CodigoProntuario {  get; set; }
    public HistoricoMedico(string codigoProntuario)
    {
        CodigoProntuario = codigoProntuario;
    }


    public void ExibirCodigo()
    {
        Console.WriteLine($"""
            Codigo do Prontuario: {CodigoProntuario}
            
            """);
    }

}
