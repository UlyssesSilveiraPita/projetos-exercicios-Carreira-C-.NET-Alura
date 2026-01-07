using System.Data;

class Consulta
{
    public string NomePaciente;
    public string NomeMedico;
    public DateTime DataConsulta;

    private bool foiReagendado;

    public Consulta(string nomePaciente, string nomeMedico, DateTime dataConsulta)
    {
        NomePaciente = nomePaciente;
        NomeMedico = nomeMedico;
        DataConsulta = dataConsulta;
        foiReagendado = false;

    }

    public void Reagendar(DateTime novaData)
    {
        foiReagendado = true;
        DataConsulta = novaData;
    }

    

    public void ExibirResumo()
    {
        
        if(foiReagendado)
        {
            Console.WriteLine($"\nConsulta marcada por {NomeMedico} para o paciente {NomePaciente}");
            Console.WriteLine($"Data: {DataConsulta}");
        }
        else
        {
            Console.WriteLine($"\nConsulta marcada por {NomeMedico} para o paciente {NomePaciente}");
            Console.WriteLine($"Data: {DataConsulta}");

        }

    }

}