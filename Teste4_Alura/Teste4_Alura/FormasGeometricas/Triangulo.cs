namespace Teste4_Alura.FormasGeometricas;

internal class Triangulo
{
    public double lado { get; set; }

    public Triangulo(double lado)
    {
        this.lado = lado;
    }
    public double CalcularArea()
    {
        return (Math.Sqrt(3) / 4) * lado * lado;
    }
    public double CalcularPerimetro()
    {
        return lado * 3;
    }
}
