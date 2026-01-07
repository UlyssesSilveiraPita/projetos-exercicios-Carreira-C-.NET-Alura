namespace Teste4_Alura.DesafioInterfacePagavel;

internal class Servico : IPagavel
{

    public double taxaHoraria {  get; set; }
    public int horasTrabalhadas { get; set; }

    double IPagavel.CalcularPagamento()
    {
        return taxaHoraria * horasTrabalhadas;
    }

}
