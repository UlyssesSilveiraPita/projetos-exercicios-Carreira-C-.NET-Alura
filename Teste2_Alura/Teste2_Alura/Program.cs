#region Inicializadores Antigos
//ContaBancaria contaBancaria = new ContaBancaria();
//Carro carro = new Carro();  
//Musica musica1 = new Musica();
//Conta conta = new Conta();
//Titular titular = new Titular();
//EstoqueDeProdutos estoque = new EstoqueDeProdutos();

#endregion
#region Cogigos Exercios anteriores

/*

titular.DefinirEndereco("Vila Velha", 45990214, "Rua das Feras");

Conta.Titular c_Titular = new Conta.Titular();

musica1.ExibirFichaTecnica();
contaBancaria.Conta();

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
numerosPares.ForEach(numero => Console.WriteLine(numero));

=====================


musica1.Nome = "Mamonas";
musica1.Artista = "Didi";

c_Titular.nome = "Ulysses";
estoque.produtos.Add(Console.ReadLine());  

Console.WriteLine(musica1.DescricaoResumida);
Console.WriteLine(musica1.Teste);



Console.WriteLine($"{c_Titular.nome}\nSeu saldo atual e de: {c_Titular.Saldo:c}\nE seu limite é de: {c_Titular.Limite:c}");

foreach(string produto in estoque.produtos)
{
    Console.WriteLine(produto );
}

string informacoesTitular = conta.ExibirInformacoes("");

conta.InformacoesTitular();


titular.DefinirEndereco("", 0, ""); // chama o método que preenche os valores
conta.InformacaoContaTitular();

Console.WriteLine(titular.ExibirTitular);

Console.WriteLine(conta.ExibirInformacoes());

estoque.ExibirProdutos();

Titular2 titular2 = new Titular2("George Harrison", "000.000.000-00", "Rua dos Besouros, Liverpool");
Conta2 c2 = new Conta2(titular2, 1, 1, 2234, 100000);
Console.WriteLine(c2.Informacoes);
*/
#endregion

Podcast podcast = new Podcast("","",0);

Episodio episodio = new Episodio("Pegaram A Cuca",1,60,"Cuca é Pega pela Emilha em uma grande Atrapalhada");

Console.WriteLine(podcast.ExibirDetalhes("",""));
Console.WriteLine(episodio.Informacoes);
episodio.AdicionarConvidados();
podcast.AdicionarEpisodios();



