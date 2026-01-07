namespace Teste4_Alura.ExercicioOO;

internal class EmailNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando E-mail: {mensagem}");
    }
}
