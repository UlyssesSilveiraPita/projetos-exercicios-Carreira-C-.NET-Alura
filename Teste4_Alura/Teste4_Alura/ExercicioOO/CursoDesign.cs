namespace Teste4_Alura.ExercicioOO;

internal class CursoDesign : ICurso
{
    public string curso = string.Empty;
    public Instrutor instrutor;

    public CursoDesign(string curso, Instrutor instrutor)
    {
        this.curso = curso;
        this.instrutor = instrutor;
    }

    public void PublicarCurso()
    {
        Console.WriteLine($""""
            Curso Publicado com Sucesso: {curso} - Istrutor: {instrutor.Nome} {instrutor.Especialidade}
            
            """");
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"""
        Validando conteudo do curso de design: {curso}
        
        """);
    }
}
