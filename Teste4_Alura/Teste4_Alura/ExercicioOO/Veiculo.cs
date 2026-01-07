namespace Teste4_Alura.ExercicioOO;

internal class Veiculo
{
    public Veiculo(string placa)
    {
        Placa = placa;
        this.velocidadeAtual = velocidadeAtual;
    }

    public string Placa {  get; set; }
    private double velocidadeAtual {  get; set; }



    public void AtualizarVelocidade(double novaVelocidade)
    {

        double VelocidadeAtual1 = novaVelocidade;

        Console.WriteLine($""" 
        Veiculo: {Placa}
        Velocidade atual: {VelocidadeAtual1} km/h
        """
        );

    }
}
