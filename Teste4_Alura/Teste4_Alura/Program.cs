#region Projeto Artista Filmes

/*
using Alura.Filmes;
Filme filme = new Filme("Um sonho de liberdade", 142, new List<Artista>() { new Artista("Tim Robbins", 65), new Artista("Morgan Freeman", 86) });
Filme filme2 = new Filme("O poderoso chefão", 175, new List<Artista>() { new Artista("Marlon Brando", 80), new Artista("Al Pacino", 83), new Artista("Talia Shire", 77) });

List<Filme> meusFilmesFavoritos = new List<Filme>();
meusFilmesFavoritos.Add(filme);
meusFilmesFavoritos.Add(filme2);


foreach (Filme f in meusFilmesFavoritos)
{
    Console.WriteLine($"Filme: {f.Titulo}");
    Console.WriteLine($"Duracao: {f.Duracao}");
    f.ListarElenco();
    Console.WriteLine();
}
*/
#endregion
#region Projeto Videos
/*
using A = VideoFlix.PlataformaA;
using B = VideoFlix.PlataformaB;

A.Video videoA = new();
B.Video videoB = new();

videoA.ExibirInformacao();
videoB.ExibirInformacao();

*/
#endregion
#region PetShop

/*
using pets = Teste4_Alura.PetShop;
using menuPetShop = Teste4_Alura.PetShop.MenuPetShop;
using menuRegistrarPet = Teste4_Alura.PetShop.MenuPetShop.MenuRegistrarPet;
using Teste4_Alura.PetShop.MenuPetShop;

pets.Consulta_medico consulta_Medico = new();
pets.Dono dono = new();
pets.Pet pet = new();   
menuPetShop.MenuPetShop menuPet = new();


Dictionary<int, MenuPetShop> opcoes = new();
opcoes.Add(1, new menuRegistrarPet());
//opcoes.Add(2, new MenuPetShop());

menuPet.ExibirMenu("PetShop Amiguinho");

Console.WriteLine(""""
            Olá bem vindo. Escolha as opcoes a baixo:

            1- Registrar Pet.
            2- Agendar Consulta.
            -1 sair. 
         
            """");

Console.WriteLine("Digite a sua Opcao: ");
string opcaoEscolhida = Console.ReadLine()!;
int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);


if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
{
    MenuPetShop menuPetShop = opcoes[opcaoEscolhidaNumerica];
    MenuPetShop.ReferenceEquals(menuPetShop, null);
}


*/

#endregion
#region Formas geometricas 
/*
using formasGeometricas =  Teste4_Alura.FormasGeometricas;


Console.WriteLine("Calculadora de Formas Geométricas");
Console.WriteLine("Escolha uma forma geométrica:");
Console.WriteLine("1. Quadrado");
Console.WriteLine("2. Retângulo");
Console.WriteLine("3. Círculo");
Console.WriteLine("4. Triângulo");
Console.Write("Opção: ");

int opcao = int.Parse(Console.ReadLine()!);
Console.WriteLine(opcao);
formasGeometricas.FormasGeometricas forma = null;

switch (opcao)
{
    case 1:
        Console.Write("Digite o lado do quadrado: ");
        double lado = double.Parse(Console.ReadLine()!);
        var quadrado = new formasGeometricas.Quadrado(lado);
        Console.WriteLine($"Área: {quadrado.CalcularArea()}");
        Console.WriteLine($"Perímetro: {quadrado.CalcularPerimetro()}");
        break;
    case 2:
        Console.WriteLine("Digite o raio do circulo: ");
        double raio = double.Parse(Console.ReadLine()!);
        var circulo = new formasGeometricas.Circulo(raio);
        Console.WriteLine($"Área: {circulo.CalcularArea()}");
        Console.WriteLine($"Perímetro: {circulo.CalcularPerimetro()}");
        break;

    case 3:
        Console.Write("Digite o lado do triângulo equilátero: ");
        double ladoTriangulo = double.Parse(Console.ReadLine()!);
        var triangulo = new formasGeometricas.Triangulo(ladoTriangulo);
        Console.WriteLine($"Área: {triangulo.CalcularArea()}");
        Console.WriteLine($"Perímetro: {triangulo.CalcularPerimetro()}");
        break;
    default:
        Console.WriteLine("Opção inválida.");
        return;
}
*/
#endregion
#region Funcionarios
/*
using funcionarios = Teste4_Alura.Funcionarios;

funcionarios.Funcionarios funcionario1  = new funcionarios.Funcionarios();
funcionario1.Nome = "DiDi";

Console.WriteLine(funcionario1.Nome);
*/
#endregion
#region ContaBancaria
/*
using contaBancaria = Teste4_Alura.ContaBancaria;

contaBancaria.ContaBase contabase = new contaBancaria.ContaBase();
contabase.NumeroConta = 32105;
contabase.Titular = "Pedro";
contabase.Saldo = 1000;
contabase.Depositar(400);

Console.WriteLine($"O saldo da conta de {contabase.Titular} é de: {contabase.Saldo}");

contabase.Sacar(200);

Console.WriteLine($"O saldo da conta de {contabase.Titular} é de: {contabase.Saldo}");
*/
#endregion
#region Desafio Animais
/*
using animaisVivos = Teste4_Alura.Animais;

animaisVivos.Animais animal = new animaisVivos.Animais(); 
animaisVivos.Mamifero mami = new animaisVivos.Mamifero();


animal.Nome = "Yuki";
mami.Especie = "Cao";
mami.EmitirSom();

Console.WriteLine($"{animal.Nome}\n{mami.Especie}\n{mami.EmitirSom()}");


*/
#endregion
#region Desafio Produtos Eletronicos
/*
using produtoEletronico = Teste4_Alura.ProdutosEletronicosCadastrados;
  
produtoEletronico.Laptop laptop1 = new produtoEletronico.Laptop();
produtoEletronico.Smartphone smart1 = new produtoEletronico.Smartphone();

laptop1.Marca = "hp";
laptop1.Modelo = "11233";
laptop1.Preco = 2000;

smart1.Marca = "Xiaumi";
smart1.Modelo = "Litei9";
smart1.Preco = 1899;


Console.WriteLine(laptop1.ExibirInformacoes());
Console.WriteLine(smart1.ExibirInformacoes());
*/
#endregion
#region Desafio Formas Geometricas
/*
using formaGeometrica = Teste4_Alura.FormaGeometricas;
formaGeometrica.Retangulo ret = new formaGeometrica.Retangulo();
formaGeometrica.Circulo cir = new formaGeometrica.Circulo();

cir.Raio = 9;

ret.Altura = 4;
ret.Largura = 5;

Console.WriteLine(ret.CalcularArea());
Console.WriteLine(ret.CalcularPerimetro());
Console.WriteLine(cir.CalcularArea());
Console.WriteLine(cir.CalcularPerimetro());
*/
#endregion
#region Desafio InterfaceVeiculos
/*
using veiculo = Teste4_Alura.VeiculosDesafio;

veiculo.Veiculo vei = new veiculo.Veiculo();

vei.Frear();

*/
#endregion
#region Desafio Interface Pagavel
/*
using Teste4_Alura.DesafioInterfacePagavel;

Produto pro = new Produto();
Servico ser = new Servico();

pro.precoUnitario = 12;
pro.quantidade = 4;

ser.taxaHoraria = 3;
ser.horasTrabalhadas = 200;


IPagavel pagavel = pro;
IPagavel servico = ser;

double valor = pagavel.CalcularPagamento();
double valor2 = servico.CalcularPagamento();

Console.WriteLine(valor);
Console.WriteLine(valor2);


*/
#endregion
#region Desafio Registro de clientes
/*
using Teste4_Alura.ExercicioOO;

ClienteVIP cliente1 = new ClienteVIP("Renata",32,"Ouro","VIP123A");
ClienteVIP cliente2 = new ClienteVIP("Leonardo", 40, "Diamante", "VIP789X");

Console.WriteLine($""""
    Bem-vindo, cliente VIP: {cliente1.Nome}
    Idade: {cliente1.Idade}
    Nivel de Fidelidade: {cliente1.nFidelidade}
    Codigo  VIP: {cliente1.cVIP}

    Bem-vindo, cliente VIP: {cliente2.Nome}
    Idade: {cliente2.Idade}
    Nivel de Fidelidade: {cliente2.nFidelidade}
    Codigo  VIP: {cliente2.cVIP}
    """");
*/
#endregion
#region Desafio Cadastro de funcionarios
/*
using Teste4_Alura.ExercicioOO;

Interno f1 = new Interno("Lucina", "Desenvolvedora", 7000.00m);
Freelancer f2 = new Freelancer("Carlos", "Designer", 3500.00m);

Console.WriteLine($""""
    Funcionario {f1.Nome} - Cargo: {f1.Cargo} - Salario: {f1.salario :c2}
    Freelancer {f2.Nome} - Cargo: {f2.Cargo} - Projeto atual: {f2.valorProjeto :c2}

    """");
*/
#endregion
#region Desafio Dados de Passageiros
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Security.Cryptography;
using Teste4_Alura.ExercicioOO;


/*
Passageiro p1 = new Passageiro("",0,0);
Passageiro p2 = new Passageiro("",0,0);

p1.ExibirInformacoes("Lucia", 45, 3);
p2.ExibirInformacoes("Rodrigo", 30, 1);

*/
#endregion
#region Desafio Certificado de Profissoes
/*
using Teste4_Alura.ExercicioOO;

Analista analista = new Analista("Analista de Sistemas");
Docente docente = new Docente("Docente de Matematica");

Certificado cerf1 = new Certificado(analista);
Certificado cerf2 = new Certificado(docente);

*/
#endregion
#region Desafio Catalogacao de itens
/*
using Teste4_Alura.ExercicioOO;

Pergaminho pergaminhoAntigo = new Pergaminho("Segredos_Antigos.txt", "A chave para a sabedoria reisde na observacao...");

pergaminhoAntigo.MostrarDetalhes();
*/
#endregion
#region Desafio Dispositivos com Sensores
/*
using Teste4_Alura.ExercicioOO;

SensorTemperatura temp = new SensorTemperatura();
SensorPresanca presenca = new SensorPresanca();

temp.Ativar();
temp.Desativar();   

presenca.Ativar();
presenca.Desativar();   
*/
#endregion
#region Desafio Montagem de Computadores
/*
using Teste4_Alura.ExercicioOO;

Processador cpu = new Processador("Intel", "i7-12700k");
PlacaMae modo = new PlacaMae("ASUS", "LGA1700");

Computador pc = new Computador(cpu, modo);

pc.ExibirConfiguracoes();
*/
#endregion
#region Desafio Sistema de Pagamentos
/*
using Teste4_Alura.ExercicioOO;

PagamentoCredito cliente1 = new PagamentoCredito("Andre","andre@email.com");
PagamentoBoleto cliente2 = new PagamentoBoleto("Juliana", "juliana@email.com");

cliente1.ProcessarPagamento();
cliente2.ProcessarPagamento();
*/
#endregion
#region Desafio Gestao de Servicos
/*
using Teste4_Alura.ExercicioOO;

Funcionario2 tecnico = new Funcionario2("Joao","TI");
IServico s1 = new Manutencao("Atualizacao de servidor", tecnico );

Funcionario2 analista = new Funcionario2("Maria", "Consultoria");
IServico s2 = new Consultoria("Planejamento estrategico",analista);

s1.ExcecutarServico();
s2.ExcecutarServico();
*/
#endregion
#region Desafio Plataforma de Cursos
/*
using Teste4_Alura.ExercicioOO;

Instrutor instrutor1 = new Instrutor("Carla","Back-end");
ICurso curso1 = new CursoProgramacao("C# com POO", instrutor1);

Instrutor instrutor2 = new Instrutor("Felipe", "UI/UX");
ICurso curso2 = new CursoDesign("Design de Interfaces", instrutor2);

curso1.ValidarConteudo();
curso1.PublicarCurso();

curso2.ValidarConteudo();
curso2.PublicarCurso();
*/
#endregion
#region Desafio Controle de Velocidade
/*
using Teste4_Alura.ExercicioOO;

Veiculo veiculo = new Veiculo("ABC-1234");
veiculo.AtualizarVelocidade(72.5);
*/
#endregion
#region Desafio Validacao de Nota minima
/*
using Teste4_Alura.ExercicioOO;

Avaliacao avaliacao = new Avaliacao("Carla Silva");
avaliacao.AtribuirNota(11);
avaliacao.AtribuirNota(8.5);
*/
#endregion
#region Desafio Controlando Acesso
/*
using Teste4_Alura.ExercicioOO;

Paciente paciente = new Paciente("Luiz Costa", 42);
HistoricoMedico historico = new HistoricoMedico("XPT-9987");
historico.ExibirCodigo();
*/
#endregion
#region Desafio Encapsulamento reajuste de Salario
/*
using Teste4_Alura.ExercicioOO;
Funcionario3 f = new Funcionario3("Fernanda Lima", 4000);
f.ReajustSalario(3500);
f.ReajustSalario(4200);
*/

#endregion
#region Desafio Controle de Tarefas
/*
using Teste4_Alura.ExercicioOO;
Projeto projeto = new Projeto("Sistema de Inventario");
projeto.AdicionarTarefa("Criar tela de login");
projeto.AdicionarTarefa("Implementar banco de dados");
projeto.ExibirTarefas();
*/
#endregion
#region Desafio Validacao de saque
/*
using Teste4_Alura.ExercicioOO;
ContaBancaria conta = new ContaBancaria("Carlos Silva", 2500);
conta.Sacar(1500);
conta.Sacar(800);
*/
#endregion
# region Desafio Agenda com Controle de Contatos duplicados
/*
using Teste4_Alura.ExercicioOO;

Agenda agenda = new Agenda("Marina Souza");
agenda.AdicionarContato(new Contato("Carlos", "11998887777"));
agenda.AdicionarContato(new Contato("Carlos", "11991112222")); // duplicado
agenda.AdicionarContato(new Contato("Julia", "21988776655"));
agenda.ListarContatos();
*/
#endregion
#region Desafio Determinando a situacao de um estudante
/*
using Teste4_Alura.ExercicioOO;

Estudante estudante = new Estudante("Lucas Rocha");
estudante.Nota1 = 7.5;
estudante.Nota2 = 5.0;

Console.WriteLine($""""
    Estudante: {estudante.Nome}
    Media: {estudante.Media}
    Situacao: {estudante.Situacao}

    """");
*/
#endregion
#region Desafio COntrole de Matricula
/*
using Teste4_Alura.ExercicioOO;

Curso curso = new Curso("Lógica de Programação", 2);
curso.Matricular(new Estudante2("Rafaela"));
curso.Matricular(new Estudante2("João"));
curso.Matricular(new Estudante2("Mirela")); // excede o limite
curso.ListarMatriculados();
*/
#endregion
#region Desafio Sistema de Reservas
/*
using Teste4_Alura.ExercicioOO;

Hospede hospede = new Hospede("Juliana Moura");
Quarto quarto = new Quarto(101);
quarto.ValorDiaria = 250;

Reserva reserva = new Reserva(hospede, quarto, 3);
*/
#endregion
#region Teste de Lambdas
/*

Func<int, int , int> somar = (a, b) => a + b;

Console.WriteLine( somar (1,3));


List<int> numeros = new List<int> {1,2,3,4,5,6};

//var pares = numeros.Where (x => x % 2 == 0).ToList();

foreach(int i in numeros)
    Console.WriteLine(i);


var par = numeros.Where (numeropar => numeropar  % 2 == 0).ToList();    


int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int[] pares = numeros.Where(n => n % 2 == 0).ToArray();

Array.ForEach(pares, Console.WriteLine);



//Crie uma expressão lambda que receba dois inteiros e retorne a soma.

Func<int , int, int> somar = (a,b) => a + b;

Console.WriteLine(somar(1,2));

//================================\\

List<int> numeros = new List<int> {1,2,3,4,5,6 };

Func<int, bool> epar = n => n % 2 == 0;

Action<string> imprimir = msg => Console.WriteLine(msg);



int somar (int a, int b)
{
    return a + b;

}
    Console.WriteLine(somar(1,7));

Func<int, int, int> somar2 = (a,b) => a + b; // forma lambda

Console.WriteLine(somar2(2,3));

//=============================================\\

List<int> numeros = new List<int> {1,2,3,4,5,6 };

int[] pares = numeros.Where(n => n % 2 == 0).ToArray();
 
Array.ForEach(pares, n => Console.WriteLine(n)); // forma lambda


//===============================================\\

var primeiroPar = numeros.Find(n => n % 2 == 0);

Console.WriteLine(primeiroPar);

//=============================================\\

List<int> pessoas = new List<int> { 17, 25, 30 };

var maiores = pessoas.Where(n => n >= 18).ToArray();

Array.ForEach(maiores, n => Console.WriteLine(n)); // forma lambda


//================================================\\

Action<string> mostrar = msg => Console.WriteLine(msg);

mostrar("Ola, lambida!");

//================================================\\

Func<int, int, int> calcular = (a, b)  => 
{
    int resultado = a * b;
    return resultado + 10;

};

Console.WriteLine(calcular(3,5));

//====================================================\\

Func<int, int> calcularBonus = p => p >= 2000 ? p + 500 : p;
Console.WriteLine(calcularBonus(2000));

//====================================================\\

Func<int, int, int> calcular3 = (a, b) =>  // lambda + ternario
{
    int resultado = a * b;

    return resultado > 50  ? +10 : resultado;

    //if (resultado > 50)
    //    resultado += 10;

    //return resultado;
};

//=========================================\\

Dictionary<string, int> inimigos = new Dictionary<string, int>
{
    { "Goblin", 100 },
    { "Orc", 300 },
    { "Dragao", 2000 }

};

var inimigoMaisForte = inimigos.OrderByDescending(m => m.Value).First(); //lambda

Console.WriteLine(inimigoMaisForte);
Console.WriteLine($"{inimigoMaisForte.Key} - {inimigoMaisForte.Value}");

*/


#endregion
#region calculadora com sobrecarga de metodo
/*
using Teste4_Alura.ExercicioOO;

Calculadora2 calc = new Calculadora2();

Console.WriteLine(calc.Somar(10,20));
Console.WriteLine(calc.Somar(5,10,15));
Console.WriteLine(calc.Somar(3.5,2.8));
*/
#endregion
#region Relatorio de Sistema
/*
using Teste4_Alura.ExercicioOO;

Funcionario4 f1 = new Gerente4();
Funcionario4 f2 = new Desenvolvedor4();

Console.WriteLine(f1.GerarRelatorio());
Console.WriteLine(f2.GerarRelatorio());
*/

#endregion
#region Notificacao de Sistema
/*
using Teste4_Alura.ExercicioOO;

List<INotificacao> notificacoes = new List<INotificacao>
{
    new EmailNotificacao(),
    new SmsNotificacao(),
    new PushNotificacao()
    

};

foreach (var notificacao in notificacoes)
{
    notificacao.EnviarMensagem("Sistema fora do ar!");
}
*/

#endregion
#region Execucao de Terefas agendadas
/*
List<TarefaAgendada> tarefas = new List<TarefaAgendada>
{
    new BackupTarefa(),
    new RelatorioTarefa(),
    new LimpezaTarefa()
};

foreach (var tarefa in tarefas)
{
    tarefa.Executar();
}
*/
#endregion
#region Exibindo midias
/*
using Teste4_Alura.ExercicioOO;

List<Midia> midias = new List<Midia>
{
    new Imagem("paisagem.jpg", "1920x1080"),
    new Video("filme.mp4", 120)

    
};

foreach (var midia in midias)
{
    midia.ExibirDetalhes();
}
*/

#endregion
#region Reserva de Experiencias
/*
using Teste4_Alura.ExercicioOO;

List<Reserva2> reservas = new List<Reserva2>
{
    new ReservaPresencial("Trillha na Serra"),
    new ReservaOnline("Workshop de Culinária Italiana")

};

foreach (var reserva in reservas)
{
    reserva.Confirmar();
}
*/
#endregion
#region Avaliacao de conteudo de em uma Plataforma
/*
using Teste4_Alura.ExercicioOO;

List<Conteudo> conteudos = new List<Conteudo>
{
    new AulaGravada("POO na Pratica", 45),
    new MaterialComplementar("Resumo do Modulo 2", 12)
};

foreach (var conteudo in conteudos)
{
    conteudo.ExibirInfo();
}    
*/
#endregion
#region Simulador de transporte Urbano
/*
List<Transporte> opcoes = new List<Transporte>
{
    new Onibus(),
    new Metro(),
    new Bicicleta()
};

int distancia = 10;

foreach (var transporte in opcoes)
{
    Console.WriteLine($"{transporte.GetType().Name}: {transporte.CalcularTempo(distancia)} min");
}
*/


#endregion
#region Calculo de juros para diferentes perfis de emprestimo
/*
List<IEmprestimo> perfis = new List<IEmprestimo>
{
    new EmprestimoEstudante(),
    new EmprestimoEmpresario(),
    new EmprestimoAposentado()

};

foreach (var perfil in perfis)
{
    decimal total = perfil.CalcularValorFinal(1000m, 12);
    Console.WriteLine($"{perfil.GetType().Name}: total: R${total: 0.00}");
}
*/
#endregion
#region Acoes em botoes e interface grafica
/*
List<IAcaoBotao> acoes = new List<IAcaoBotao>
{ 
    new SalvarAcao(),
    new EditarAcao(),
    new ExcluirAcao()

};

foreach (var acao in acoes)
{
    acao.Executar();
}
*/
#endregion
#region Consumindo API introducao
/*
using (HttpClient client = new HttpClient())
{

    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);

    }
    catch (Exception ex)
    {
        Console.WriteLine($"temos um problema: {ex.Message}");
    }

}

    try
    {
        for (int i = 0; i < 10; i--)
        {
            Console.WriteLine($"{10/i}");
        }

    }
        catch (Exception ex)
        {
        Console.WriteLine( "tivemos um problema");
        }
*/
#endregion
#region Comsumindo API hora da pratica

//1- 
/*
using (HttpClient client = new HttpClient())
{
    string respostaAPI = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
    Console.WriteLine(respostaAPI);
}
*/

//2- 
/*
int a;
int b;
int cont = 0;

Console.WriteLine("Digite 2 numero para serem divididos: ");
do
{
    try
    {
        cont++;
        Console.WriteLine("Qual o n: ");
        a = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Qual o n: ");
        b = int.Parse(Console.ReadLine()!);
        
        int div = a / b;
        Console.WriteLine($"A divisou foi: {div}");

    }
    catch (Exception ex)
    {
        Console.WriteLine("O que foi digitado nao e um numero. Tente novamente");
    }
    
}while ( cont < 1);
*/

//3-
/*
List<int> ints = new List<int> {1,2,3,4,5,6};

try
{
    Console.WriteLine(ints[7]);

}
catch (Exception ex)
{


    Console.WriteLine("Item da lista não existe!!!");
}

//4-
HoraPratica4_ teste = new HoraPratica4_();

try
{
    teste = null;
    teste.TesteNullo();

}
catch
{
    Console.WriteLine("nao ha nada dentro do metodo");
}
*/
#endregion
#region Consumo de API Hora da pratica Filmes
/*
using Teste4_Alura.ConsumindoAPI;
using System.Text.Json;
using (HttpClient client = new HttpClient())
{ 
    
    try
    {

        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        List<Filmes> filmes = JsonSerializer.Deserialize<List<Filmes>>(resposta)!;

        string respostaPais = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        List<Pais> pais = JsonSerializer.Deserialize<List<Pais>>(respostaPais)!;

        string respostaCarro = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        List<Carro> carro = JsonSerializer.Deserialize<List<Carro>>(respostaCarro)!;

        string respostaLivros = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        List<Livro> livro = JsonSerializer.Deserialize<List<Livro>>(respostaLivros)!;

        string respostaGameOFThornes = await client.GetStringAsync("https://www.anapioficeandfire.com/api/characters/16");
        GameOfThronesAPI personagem = JsonSerializer.Deserialize<GameOfThronesAPI>(respostaGameOFThornes)!;


        foreach(Filmes filme in filmes)
            {
                Console.WriteLine(filme.ExibirFichaTecnicaFilme);
            }

        foreach(Pais paises in pais)
        {
            Console.WriteLine(paises.ExibirListadosPaises);
        }

        foreach (Carro car in carro)
        {
            Console.WriteLine(car.ExibirListadeCarro);
        }

        foreach (Livro livr in livro)
        {
            Console.WriteLine(livr.ExibirDetalhesLivro);
        }


        Console.WriteLine(personagem.ExibirConteudoGameofThrones);



    }
    catch (Exception ex)
    {
            Console.WriteLine($"Error: {ex.Message}");
    }

}
*/
#endregion
#region

#endregion


