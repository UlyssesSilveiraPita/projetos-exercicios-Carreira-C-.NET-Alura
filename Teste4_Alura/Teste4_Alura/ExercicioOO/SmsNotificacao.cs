namespace Teste4_Alura.ExercicioOO;

internal class SmsNotificacao : INotificacao
{
    public void EnviarMensagem(string menagem)
    {
        Console.WriteLine($"Enviando SMS: {menagem}");
    }
}
