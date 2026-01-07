namespace Teste4_Alura.ExercicioOO;

internal class MaterialComplementar : Conteudo
{
    public int nPaginas {  get; set; }
    public MaterialComplementar(string titulo, int nPaginas) : base(titulo)
    {
        this.nPaginas = nPaginas;
    }

    public override void ExibirInfo()
    {
        Console.WriteLine($""""

            Titulo: {Titulo}
            Paginas: {nPaginas}
            """");
    }
}
