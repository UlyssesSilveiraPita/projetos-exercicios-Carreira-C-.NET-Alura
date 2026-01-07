#region Ex Livro da Biblioteca
/*
Livro livro = new Livro();

livro.titulo = "Dom Casmurro";
livro.autor = "Machado de Assis";

Console.WriteLine($"Livro: {livro.titulo}\nAutor: {livro.autor}");
*/
#endregion
#region Emissao de Passagem
/*
Passagem passagem = new Passagem();

passagem.CriandoPassagem("Lucas Souza", "Paris");

*/
#endregion
#region Conta Bancaria
/*
ContaBancaria contabacaria = new ContaBancaria("",0f);
contabacaria.InformacoesConta();
*/
#endregion
#region Gerenciamento de Funcionarios
/*
Funcionario funcionario = new Funcionario("","");
funcionario.Promover("");
*/
#endregion
#region Representando retangulos e calculos de area 
/*
Retangulo retangulo = new Retangulo();
Console.Write($"Area do Retangulo: {retangulo.CalcularArea()}");
*/
#endregion
#region Validacao de acesso a filmes
/*
Filme filme = new Filme("Matrix",16);
filme.PodeAssistir(0);
*/
#endregion
#region Controle de Estoque
/*
Produto produto = new Produto("Caneta Azul",20);
Console.WriteLine(produto.Retirada(0));
*/
#endregion
#region Representando um Pedido de Compras
/*
Pedido pedido = new Pedido("001","Ana Silva","Pendente");
pedido.ExibirPedido();
pedido.AtualizarStatus("Enviado");
pedido.ExibirPedido();
*/
#endregion
#region Agendamento Medico
/*
Consulta consulta = new Consulta("João Lima", "Dra. Renata", new DateTime(2025, 5, 20));
consulta.ExibirResumo();
consulta.Reagendar(new DateTime(2025, 5, 25));
consulta.ExibirResumo();
*/
#endregion
#region Produto Digital Informatica
/*
InformacaoTecnica info = new InformacaoTecnica(1500, "Windows/Mac");
ProdutoDigital produto = new ProdutoDigital("Photoshop", 89.99, info);
produto.ExibirDetalhes();
*/
#endregion
#region Desafio Filmes
using Alura.Filmes;

Filme filme = new Filme2("Um sonho de liberdade", 142, new List<Artista>() { "Tim Robbins",2, "Morgan Freeman" });
Filme filme2 = new Filme2("O poderoso chefão", 175, new List<Artista>() { "Marlon Brando", "Al Pacino", "Talia Shire" });
Filme filme3 = new Filme2("Batman - O Cavaleiro das Trevas", 152, new List<Artista>() { "Christian Bale", "Heath Ledger", "Maggie Gyleenhaal" });
Filme filme4 = new Filme2("Senhor dos Anéis - O Retorno do Rei", 201, new List<Artista>() { "Elijah Wood", "Ian McKellen", "Viggo Mortensen" });
Filme filme5 = new Filme2("Green Book - O Guia", 130, new List<Artista>() { "Viggo Mortensen", "Mahershala Ali" });

List<Filme> meusFilmesFavoritos = new List<Filme>();
meusFilmesFavoritos.Add(filme);
meusFilmesFavoritos.Add(filme2);
meusFilmesFavoritos.Add(filme3);
meusFilmesFavoritos.Add(filme4);
meusFilmesFavoritos.Add(filme5);

foreach (Filme f in meusFilmesFavoritos)
{
    Console.WriteLine($"Filme: {f.Titulo}");
    Console.WriteLine($"Duracao: {f.Duracao}");
    f.ListarElenco();
    Console.WriteLine();
}

#endregion