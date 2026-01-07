namespace Teste4_Alura.ExercicioOO;

internal class SensorPresanca : ISensor
{
    public string Ativar()
    {
        Console.WriteLine("Sensor de presenca ativado");

        return "";
    }

    public string Desativar()
    {
        Console.WriteLine("Sensor de presenca desativado");

        return "";
    }


}
