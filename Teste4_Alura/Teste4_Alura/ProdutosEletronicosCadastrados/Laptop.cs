namespace Teste4_Alura.ProdutosEletronicosCadastrados;

internal class Laptop : ProdutoEletronico
{
    public override string ExibirInformacoes()
    {
        return $"Marca: {Marca}, Modelo: {Modelo}, Preço: R${Preco}";
    }
}
