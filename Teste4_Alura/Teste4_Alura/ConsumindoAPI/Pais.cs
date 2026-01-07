using System.Text.Json.Serialization;

namespace Teste4_Alura.ConsumindoAPI;

internal class Pais
{
    [JsonPropertyName("nome")]
    public string? Nome { get; set; }

    [JsonPropertyName("capital")]
    public string? Capital { get; set; }

    [JsonPropertyName("continente")]
    public string? Continente { get; set; }

    public string ExibirListadosPaises => 
        $""" 
         Nome do Pais: {Nome}
         Nome da Capital: {Capital}
         Nome do Continente: {Continente}

        """;
        

}
