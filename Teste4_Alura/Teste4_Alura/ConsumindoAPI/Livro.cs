using System.Text.Json.Serialization;

namespace Teste4_Alura.ConsumindoAPI;

internal class Livro
{
    [JsonPropertyName("titulo")]
    public string? Titulo { get; set; }
    [JsonPropertyName("autor")]
    public string? Autor {  get; set; }
    [JsonPropertyName("genero")]
    public string? Genero { get; set; }

    public string ExibirDetalhesLivro =>
        $""""
        Nome do Livro: {Titulo}
        Nome do Autor: {Autor}
        Genero do Livro: {Genero}

        """";

}
