class Filme
{
    public Filme(string titulo, int classificacaoEtaria)
    {
        Titulo = titulo;
        ClassificacaoEtaria = classificacaoEtaria;
    }

   public string Titulo;
   public int ClassificacaoEtaria;

    public void PodeAssistir(int idadeUsuario)
    {
        Console.Write("Digite sua idade: ");
        idadeUsuario = int.Parse(Console.ReadLine()!);

        if (idadeUsuario > ClassificacaoEtaria)
        {
            Console.WriteLine($"Usuário com {idadeUsuario} anos pode assistir ao filme Matrix.");
        }
        else
        {
            Console.WriteLine($"Usuário com {idadeUsuario} anos não pode assistir ao filme Matrix.");
        }
    }

}