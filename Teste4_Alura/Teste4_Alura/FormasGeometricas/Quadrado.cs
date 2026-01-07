namespace Teste4_Alura.FormasGeometricas;

internal class Quadrado
{
    public double lado { get; set; }

    public Quadrado(double lado)
    {
        this.lado = lado;
    }

    public new double CalcularArea()
    {
        return lado * lado;
    }
    public new double CalcularPerimetro()
    {
        return lado * 4;
    }
}