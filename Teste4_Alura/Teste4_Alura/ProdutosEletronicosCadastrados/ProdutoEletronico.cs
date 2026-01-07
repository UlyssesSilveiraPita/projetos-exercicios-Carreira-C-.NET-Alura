namespace Teste4_Alura.ProdutosEletronicosCadastrados;

internal class ProdutoEletronico
{
    public decimal Preco { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public virtual string ExibirInformacoes()
    {
        return "";
    }
}
