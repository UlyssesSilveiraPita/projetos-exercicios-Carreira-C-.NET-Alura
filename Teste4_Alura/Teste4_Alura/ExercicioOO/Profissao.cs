namespace Teste4_Alura.ExercicioOO;

abstract class Profissao
{
    public string Titulo { get; set; }
    protected Profissao(string titulo)
    {
       this.Titulo = titulo;
    }


}
