class Funcionario
{
    public Funcionario(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }

    public string  Nome { get; private set; }
    public string Cargo { get; private set; }

    public void Promover(string novoCargo)
    {
        Nome = "Carlos Pereira";
        Cargo = "Assistente Administrativo";


        Console.WriteLine($"""" 
        Funcionario: {Nome}
        Cargo Atual: {Cargo}

        """");

        Console.WriteLine("Digite um Novo Cargo");
        novoCargo = Console.ReadLine()!;

        if(String.Equals(Cargo , novoCargo))
        {

            Console.WriteLine("\nErro: O novo cargo deve ser diferente do cargo atual");
        }
        else
        {
            Console.WriteLine("\n--- Promocao realizada com Sucesso ---");
            Console.WriteLine($"""" 
            Funcionario: {Nome}
            Cargo Atual: {novoCargo}
            
            """");
        }


    }
    
   

}