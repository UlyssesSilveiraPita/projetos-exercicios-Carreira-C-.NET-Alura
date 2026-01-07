namespace Teste4_Alura.ExercicioOO;

internal class ReservaOnline : Reserva2
{
    public string Nome { get; set; }
    public ReservaOnline(string nome)
    {
        Nome = nome;
    }

    public override void Confirmar()
    {
        Console.WriteLine($""""

            Confirmado reserva online: {Nome}
            Link de acesso enviado por e-mail!
            """");
    }

}
