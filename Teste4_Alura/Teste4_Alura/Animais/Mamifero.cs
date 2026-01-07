using System.Net.Http.Headers;

namespace Teste4_Alura.Animais;

internal class Mamifero : Animais
{
   public string Especie { get; set; }

    public override string EmitirSom()
    {
        return "Au au";
    }
}
