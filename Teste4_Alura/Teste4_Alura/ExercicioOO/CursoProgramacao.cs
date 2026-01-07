namespace Teste4_Alura.ExercicioOO;

internal class CursoProgramacao : ICurso
{
    public string curso = string.Empty;
    public Instrutor instrutor;



    public CursoProgramacao(string curso, Instrutor instrutor)
    {
        this.curso = curso;
        this.instrutor = instrutor;
    }

    public void PublicarCurso()
    {
        Console.WriteLine($""""
            Curso Publicado com Sucesso: {curso} - Istrutora: {instrutor.Nome} {instrutor.Especialidade}
            
            """");
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"""
        Validando conteudo do curso de programacao: {curso}
        
        """);
    }
}
