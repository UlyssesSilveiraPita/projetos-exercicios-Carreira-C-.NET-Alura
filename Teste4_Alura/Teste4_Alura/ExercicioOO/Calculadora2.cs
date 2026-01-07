namespace Teste4_Alura.ExercicioOO;

internal class Calculadora2
{
    public int n1 {  get; private set; }
    public int n2 {  get; private set; }
    public int n3{  get; private set; }

    public int Somar (int n1, int n2)
    {
        return n1 + n2;
    }

    public int Somar (int n1, int n2, int n3)
    {
        return n1 + n2 + n3;
    }

    public double Somar(double n1, double n2)
    {
        return n1 + n2;
    } 
}
