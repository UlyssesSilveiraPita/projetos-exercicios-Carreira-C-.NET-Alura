namespace Teste4_Alura.ExercicioOO;

internal class SensorTemperatura : ISensor
{
    public string Ativar()
    {
        Console.WriteLine("Sensor de temperatura ativado");
        return "";
    }

    public string Desativar()
    {
        Console.WriteLine("Sensor de temperatura desativado");
        return "";
    }
}
