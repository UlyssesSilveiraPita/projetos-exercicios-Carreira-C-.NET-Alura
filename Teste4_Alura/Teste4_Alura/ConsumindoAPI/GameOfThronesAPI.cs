using System.Text.Json.Serialization;

namespace Teste4_Alura.ConsumindoAPI;

internal class GameOfThronesAPI
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("gender")]

    public string? Genero { get; set; }

    [JsonPropertyName("titles")]

    public string[]? Titulo { get; set; }

    public string ExibirConteudoGameofThrones =>
        $"""
        Nome: {Name}
        Genero: {Genero}
        Titulo: {string.Join(", ", Titulo ?? [])}

        """;
}
