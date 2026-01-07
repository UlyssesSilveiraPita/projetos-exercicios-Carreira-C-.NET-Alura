namespace Teste4_Alura.ExercicioOO;

internal class Quarto
{
    public int Numero {  get; set; }

    public Quarto(int numero)
    {
        Numero = numero;
    }

    private int _valorDiaria;
    public int ValorDiaria
    {
        get => _valorDiaria;

        set
        {
            if (value >= 0)
            _valorDiaria = value;
        }


    }
    

}
