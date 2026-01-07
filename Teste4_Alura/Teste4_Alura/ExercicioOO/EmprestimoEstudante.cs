namespace Teste4_Alura.ExercicioOO;

internal class EmprestimoEstudante : IEmprestimo
{
    public decimal ValorFinal { get; set; }
    public decimal Taxa { get; set; }
    public decimal ValorEmprestado { get; set; }

    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        Taxa = 1m / 100;
        ValorEmprestado = valor;

        ValorFinal = ValorEmprestado + (valor * Taxa * meses);
        return ValorFinal;
    }
}
