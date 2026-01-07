namespace Teste4_Alura.ExercicioOO;

internal class Onibus : Transporte
{
    public int distancia { get; set; }
   

    public override int CalcularTempo(int distanciaKm)
    {
        return base.CalcularTempo(distanciaKm *2) + 5;

    }
}
