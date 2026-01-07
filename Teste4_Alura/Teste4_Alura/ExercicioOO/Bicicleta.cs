namespace Teste4_Alura.ExercicioOO;

internal class Bicicleta : Transporte
{
    public override int CalcularTempo(int distanciaKm)
    {
        return base.CalcularTempo(distanciaKm * 4);
    }

}
