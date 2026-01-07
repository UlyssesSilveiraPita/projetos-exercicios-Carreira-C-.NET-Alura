namespace Teste4_Alura.Funcionarios;

internal class Programador : Funcionarios
{
    public string Nivel {  get; set; }
    public List<string> Linguagens { get; set; }
    public Programador()
    {
        Linguagens  = new List<string>();   
    }

}
