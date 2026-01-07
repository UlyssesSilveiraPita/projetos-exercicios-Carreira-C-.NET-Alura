namespace Teste4_Alura.ProdutosEletronicosCadastrados;

internal class Smartphone : ProdutoEletronico
{
    public override string ExibirInformacoes()
    {
        return $"Marca: {Marca}, Modelo: {Modelo}, Preço: R${Preco}";
    }
}
