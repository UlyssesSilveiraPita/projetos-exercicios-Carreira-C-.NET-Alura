using System.Text.Json.Serialization;

namespace Teste4_Alura.ConsumindoAPI;

internal class Filmes
{
    [JsonPropertyName("title")]
    public string? Nome { get; set; }

    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    public string ExibirFichaTecnicaFilme => 
        $"""
        Title {Nome} 
        Ano {Ano}

        """;
}
