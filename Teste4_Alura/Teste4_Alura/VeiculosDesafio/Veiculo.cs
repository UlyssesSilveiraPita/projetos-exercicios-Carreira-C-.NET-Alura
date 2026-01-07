namespace Teste4_Alura.VeiculosDesafio;

internal class Veiculo : IVoavel, IPilotavel
{
    void IPilotavel.Acelerar()
    {
        Console.WriteLine($"Acelerando o veículo.");

    }

    void IVoavel.Decolar()
    {
        Console.WriteLine($"Decolando o veículo.");

    }

    public string Frear()
    {
        Console.WriteLine($"Freando o veículo..");
        return "";
    }

    void IVoavel.Pousar()
    {
        Console.WriteLine("Pousando o veículo...");

    }


}
