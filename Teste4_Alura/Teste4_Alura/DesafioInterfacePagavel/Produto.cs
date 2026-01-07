namespace Teste4_Alura.DesafioInterfacePagavel;

internal class Produto : IPagavel
{
    public double precoUnitario { get; set; }
    public int quantidade { get; set; }
    
    double IPagavel.CalcularPagamento()
    {

        return precoUnitario * quantidade;

    }

  
}
