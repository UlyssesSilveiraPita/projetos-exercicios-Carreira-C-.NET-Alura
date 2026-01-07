namespace Teste4_Alura.ExercicioOO;

internal class Metro : Transporte
{
    public override int CalcularTempo(int distanciaKm)
    {
        return base.CalcularTempo(distanciaKm + 5);
    }
}
