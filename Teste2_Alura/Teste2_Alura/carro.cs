class Carro
{

    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public int Ano2 { get; set; }
    public int QuantidadePortas { get; set; }
    public string DescricaoDetalhada2 => $"Modelo do carro: {this.Fabricante} {this.Modelo} {this.Ano2}";

    public string Nome { get; set; } = "uno";
    public int Ano
    {
        get => Ano;
        set
        {
            if (value < 1960 || value > 2023)
            {
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
            }
            else
            {
                Ano = value;
            }
        }
    }

    public string fabricante = "Fiat";

    public string DescricaoDetalhada 
    { get
        {
            return $""""
                
                Fabricante: {fabricante}
                Modelo: {Nome}
                Ano do Carro: {Ano}                

                """";
        }
            
            
    }


    public void Acelerar ()
    {

    }
    public void Frear ()
    {

    }

    public void Buzinar()
    {

    }


}

