namespace Teste4_Alura.ExercicioOO;

internal class Reserva
{
    private int diaria;
    public Hospede Hosped {get;}
    public Quarto Quarto { get;}
    public  double valorTotal { get;}

    public Reserva(Hospede hosped, Quarto quarto, int diaria)
    {
        this.diaria = diaria;
        Hosped = hosped;
        Quarto = quarto;
        valorTotal = CalcularValorTotal();

        Console.WriteLine($""""
            Reserva para: {hosped.Nome}
            Quarto: {Quarto.Numero}
            valor total: {valorTotal:c2}
            """");

    }

    private int CalcularValorTotal()
    {
        return (int)(diaria * Quarto.ValorDiaria);
    }

}
