using System.Text.Json.Serialization;

namespace Teste4_Alura.ConsumindoAPI;

internal class Carro
{
    [JsonPropertyName("marca")]
    public string? Marca { get; set; }

    [JsonPropertyName("modelo")]
    public string? Modelo { get; set; }

    [JsonPropertyName("ano")]
    public int? Ano { get; set; }

    public string ExibirListadeCarro =>
        $"""
        Marca do Carro: {Marca}
        Modelo do Carro: {Modelo}
        Ano do carro: {Ano}

        """;

}
