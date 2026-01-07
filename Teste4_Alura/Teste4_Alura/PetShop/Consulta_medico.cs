namespace Teste4_Alura.PetShop;

internal class Consulta_medico
{
    public class Medico
    {
        public Medico(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
    }

    public class Consulta
    {
        public Consulta(Pet paciente, Medico medico, string data)
        {
            Paciente = paciente;
            MedicoResponsavel = medico;
            Data = DateTime.Parse(data);
            ConsultaAgendada = true;
            paciente.ConsultasAgendadas.Add(0);
        }
        public Pet Paciente { get; set; }
        public Medico MedicoResponsavel { get; set; }
        public DateTime Data { get; set; }

        protected bool ConsultaAgendada { get; set; }

        public void DesmarcarConsulta(Pet paciente)
        {
            ConsultaAgendada = false;
            paciente.ConsultasAgendadas.Remove(0);
            Console.WriteLine("Consulta desmarcada!");
        }
    }
}