namespace Teste4_Alura.FormasGeometricas;

internal class Circulo
{
    public double raio { get; set; }
    public Circulo(double raio)
    {
        this.raio = raio;
    }
    public double CalcularArea()
    {
        return Math.PI * Math.Pow(raio, 2);
    }
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * raio;
    }
}
