namespace Teste4_Alura.ExercicioOO;

internal class ReservaPresencial : Reserva2
{
    public string Nome {  get; set; }
    public ReservaPresencial(string nome)
    {
        Nome = nome;
    }


    public override void Confirmar()
    {
        Console.WriteLine($""""
            Confirmado reserva Presencial: {Nome}
            Ponto de encontro: Praca Central, as 8h
            """");

    }


}
