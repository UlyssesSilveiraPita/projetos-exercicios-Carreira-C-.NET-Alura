namespace Teste4_Alura.ExercicioOO;

internal class Computador 
{
    Processador processador {get; set;}
    PlacaMae placaMae { get; set; }
    public Computador(Processador cpu, PlacaMae mobo)
    {
        this.processador = cpu;
        this.placaMae = mobo;   
    }


    public void ExibirConfiguracoes()
    {
        Console.WriteLine($""""
            Computador configurado com: 

            Processador: {processador.Marca} - {processador.Modelo} 

            Placa-mae: {placaMae.Fabricante} - {placaMae.Socket}
            """");
    }

}
