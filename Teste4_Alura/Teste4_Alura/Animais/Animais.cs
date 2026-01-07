namespace Teste4_Alura.Animais;

internal class Animais
{
    public string Nome { get; set; }
    public int Idade {  get; set; }

    public virtual string EmitirSom()
    {
        return "";
    }
}
