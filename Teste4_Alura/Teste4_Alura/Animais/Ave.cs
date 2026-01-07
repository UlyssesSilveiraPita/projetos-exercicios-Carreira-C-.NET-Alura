namespace Teste4_Alura.Animais;

internal class Ave : Animais
{
    public string Especie { get; set; }
    
    public override string EmitirSom()
    {
        return "Piu Piu";
    }

}
