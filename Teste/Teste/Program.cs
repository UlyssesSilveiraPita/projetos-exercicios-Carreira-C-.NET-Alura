
/*
Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);
Console.WriteLine(numeroSecreto);

do
{
    Console.Write("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número.");
        break;
    }
    else if (chute < numeroSecreto)
    {
        Console.WriteLine("O número é maior.");
    }
    else
    {
        Console.WriteLine("O número é menor.");
    }

} while (true);

Console.WriteLine("O jogo acabou. Você acertou o número secreto!");



int numeroAleatorio = new Random().Next(1, 101);
int numeroSortedo = numeroAleatorio;
int numeroEscolhido = 0 ;


Console.WriteLine(numeroSortedo); // ja saber qual o numero que foi sorterado
Console.WriteLine("Vamos comercar o Jogo Escolha um numero de 1 a 100");

do
{
    numeroEscolhido = int.Parse(Console.ReadLine()!);
   

    if(numeroEscolhido == numeroSortedo)
    {
        Console.WriteLine("Paranbens voce acertou");
        break;
    }
    else if(numeroEscolhido < numeroSortedo)
    {
        Console.WriteLine("Que pena o numero da sorte é maior tente novamente!");
    }
    else if(numeroEscolhido > numeroSortedo)
    {
        Console.WriteLine("Que pena o numero da sorte é menor tente novamente!");
    }


} while (numeroEscolhido != numeroSortedo);




//1.


void OperacoesBasicas()
{
    float A = 5.0f;
    float B = 3.0f;

    float adicao = A + B;
    float subtracao = A - B;
    float divisao = A / B;
    float multiplicacao = A * B;

    Console.WriteLine($"Resultados:\nAdicao:{adicao}\nSubtracao:{subtracao}\nDivisao:{divisao}\nMultiplicacao:{multiplicacao}");

}

OperacoesBasicas();

//2. 

List<string> bandas = new List<string>();
bandas.Add("\nMamonas Assassinas");
bandas.Add("Angra");
Console.WriteLine(bandas[0]);

//3.

foreach(string band in bandas)
{
    Console.WriteLine(band);
}

//4.
*
List<int> nInteiros = new List<int>() {2,3,4,5 };
Console.WriteLine(nInteiros.Count);
int soma = 0;

foreach(int n in nInteiros)
{
    soma += n;
}


Console.WriteLine(soma);


for (int i = 0; i < nInteiros.Count; i++)
{
    Console.WriteLine(nInteiros[i]);

    soma = nInteiros[0] + nInteiros[1] + nInteiros[2] + nInteiros[3];
}
Console.WriteLine(soma);



List<int> listaInteiros = new List<int>() {1,2,3,4,5};

for (int i = 0; i < listaInteiros.Count; i++)
{
    //int list = listaInteiros[i];

    if (listaInteiros[i] % 2 == 0)
    {
        Console.WriteLine(listaInteiros[i]);
    }


}

foreach (int n in listaInteiros)
{
    if (n % 2 == 0)
    {
        Console.WriteLine(listaInteiros);

    }

}



//1.

Dictionary<string, List<int>> aluno = new Dictionary<string, List<int>>();

aluno.Add("C#", [10, 8, 9, 8]);

int soma = 0;
float media = 0;

foreach (var value in aluno)
{
    soma += value.Value.Sum();
    media = (float)soma / 4;
}

Console.WriteLine(media);

//2.

string nomeProduto = Console.ReadLine()!;

Dictionary<string, int> produtos = new Dictionary<string, int>()
{
    {"camisa", 40 },
    {"calca", 50 },
    {"bota", 20 }

};

foreach (var value in produtos)
{
    if(nomeProduto.Contains(value.Key))
    {
        Console.WriteLine(value.Value);
    }

}

//3.

Dictionary<string, string> perguntas = new Dictionary<string, string> 
{
    {"Qual a cor do Céu de dia?", "azul" },
    {"quanto é 2 + 2", "4" },

};


Console.WriteLine("Responda as perguntas a seguir:\n");

foreach (var item in perguntas)
{
    Console.WriteLine(item.Key);

    string resposta = Console.ReadLine().ToLower()!;

    while (resposta != item.Value)
    {
        Console.WriteLine("Tente novamente:");
        resposta = Console.ReadLine().ToLower()!;
    }

    Console.WriteLine("Parabéns, você acertou!\n");
}


//4.

Dictionary<string, List<int>> loguin = new Dictionary<string, List<int>>();

Console.WriteLine("Faca seu Loguin");
Console.WriteLine($"Digite seu Nome e senha");

Console.WriteLine("\nNome ");
string nome = Console.ReadLine()!;

Console.WriteLine("Senha: ");
int senha = int.Parse(Console.ReadLine());  

loguin.Add(nome, new List<int> {senha});

foreach (var item in loguin)
{
    Console.WriteLine($"Nome: {item.Key}");

    foreach( var item2 in item.Value)
    {
        Console.WriteLine($"Senha: {item2}" );
    }
}



    Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

Console.WriteLine("Digite o nome do carro para calcular a média:");
string chave = Console.ReadLine()!;

if (vendasCarros.ContainsKey(chave))
{
    double mediaCarros = vendasCarros[chave].Average();
    Console.WriteLine($"A média anual de vendas de '{chave}' é: {mediaCarros}");
}
else
{
    Console.WriteLine("Carro não encontrado.");
}


// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso"};  
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas e suas notas");

    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach (var banda in bandasRegistradas )
    {
        Console.WriteLine($"Banda: {banda.Key}");
        Console.WriteLine("Notas Atribuidas a banda:");

        foreach (var item2 in banda.Value)
        {
            Console.WriteLine($"{item2}");
        }

    }
    

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    //digite qual banda deseja avaliar
    // se a banda exitir no dicionario >> atribuir uma nota
    // senão, volta ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da banda");
    Console.WriteLine("Bandar Registradas até momento: \n");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.Write("\nDigite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para votar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}


ExibirOpcoesDoMenu();



//1.

using System.Runtime.Serialization.Json;

int anoNascimento = 1986;
int anoAtual = 2025;
int idadeAtual = anoAtual -  anoNascimento;

Console.WriteLine($"Sua idade é: {idadeAtual}");

//2. 

decimal doacoes;
string identificacao;
bool anonimo;
char tipoConta;


Console.WriteLine("Faca a sua Doacoa");
doacoes = decimal.Parse(Console.ReadLine());
Console.WriteLine("Gostaria de se Identificar? S/N");
identificacao = Console.ReadLine().ToUpper();

if (identificacao == "S")
{
    Console.WriteLine("Como se Chama: ");
    Console.ReadLine();
    anonimo = false;
    }
else
{
    anonimo = true;
}

Console.WriteLine("Para qual conta gostaria de fazer o Deposito Poupanca ou Corrente? P/C");
tipoConta = Console.ReadLine().ToUpper().First();


Console.WriteLine($"Valor recebido:{doacoes:c}");
Console.WriteLine($"A Doacao foi Anonima: {anonimo}");
Console.WriteLine($"Tipo da conta: {tipoConta}");



//3.

double unidadeMilhas = 1.60934;
string valorDigitado = Console.ReadLine()!;
double valor = Convert.ToDouble(valorDigitado);
double calculoMilhas = valor * unidadeMilhas;

Console.WriteLine(calculoMilhas);


//4.

int minutos = 250;
int hora = minutos / 60;
int valorCalculo = minutos % 60;


Console.WriteLine($"Tempo: {hora} horas e {valorCalculo} minutos");


//5.
double largura = 10.5;
double comprimento = 20.3;

double area = largura * comprimento;

Console.WriteLine($"A área do terreno é: {area} metros quadrados");



//6.

float[] notas = new float[3];

notas = [7.2f, 8.3f, 9.1f];

Console.WriteLine($"A média das notas é: {notas.Average()}");


//7.

decimal pesoContainer = 18.75m;
int pesoContainerTonelada = (int)pesoContainer;

Console.WriteLine($"Veículos necessarios {pesoContainerTonelada} ");


//8.

int vidas = 5;
vidas--;
vidas++;
vidas++;
int vidasFinais = vidas;

Console.WriteLine("Vidas finais: " + vidasFinais);


//9.

decimal salarioAtual = 1500.00m;
decimal percentual =  (salarioAtual * 10) / 100 ;
decimal novoSalario = salarioAtual + percentual;

Console.WriteLine($"O novo salario é de R${novoSalario}");


//10.

double raio = 5.0;
double pi = Math.PI;
double areaCirculo = pi * raio * raio;
double perimetroCirculo = 2 * pi * raio;

Console.WriteLine($"Raio: {raio.ToString("F2")}");
Console.WriteLine($"Area do Circulo: {areaCirculo.ToString("F2")}");
Console.WriteLine($"Perimetro do Circulo: {perimetroCirculo.ToString("F2")}");



//============= if/else =========\\

//1

int saldo = int.Parse(Console.ReadLine());

if (saldo == 0)
{
    Console.WriteLine("seu saldo é 0");
}
else if(saldo > 0)
{
    Console.WriteLine($"Seu saldo é {saldo}");
}
else
{
    Console.WriteLine($"seu saldo é negativo");
}


//2.

Console.WriteLine("Digite o codigo do produto 1 para perecivel e 2 para nao perecivel: 1 ou 2");
int codigoProduto = int.Parse(Console.ReadLine());


string tipoProduto = (codigoProduto == 1) ? "Perecivel" :
                     (codigoProduto == 2) ? "Nao perecivel" : 
                     "Codigo invalido é somente 1 ou 2";

Console.WriteLine(tipoProduto);


//3.

Console.WriteLine("Informe a nota final do aluno");
double notaAluno = double.Parse(Console.ReadLine());

switch (notaAluno)
{
    case >= 9:
        Console.WriteLine("O Aluno recebou Nota A");

        break;
    case >= 7:
        Console.WriteLine("O Aluno recebou Nota B");

        break;
    case >= 5:
        Console.WriteLine("O Aluno recebou Nota C");

        break;
    case < 5:
        Console.WriteLine("O Aluno recebou Nota D");

        break;
}


//4.

Console.WriteLine("Digite a senha");
int senha = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o nivel de acesso: ");
int acesso = int.Parse(Console.ReadLine()); 

if (senha == 42 && acesso >= 5 )
{
    Console.WriteLine("Acesso liberado tenha um dia para destruir o mundo kkk ");
}
else
{
    Console.WriteLine("Acesso negado");

}


//5.

//Console.WriteLine("Digite a idade: ");
//int idade = int.Parse(Console.ReadLine());

//switch(idade)
//{
//    case <= 0:
//        Console.WriteLine("Classificacao: Infantil");

//        break;

//    case <= 12:
//        Console.WriteLine("Classificacao: Infantil");

//        break;

//    case <= 13:
//        Console.WriteLine("Classificacao: Adolescente");

//        break;

//    case <= 17:
//        Console.WriteLine("Classificacao: Adolescente");

//        break;

//    case <= 18:
//        Console.WriteLine("Classificacao: Adulto");

//        break;

//    case <= 59:
//        Console.WriteLine("Classificacao: Adulto");

//        break;

//    case >= 60:
//        Console.WriteLine("Classificacao: Idoso");

//        break;

//}
//Console.WriteLine($"Classificacao {idade}");

Console.WriteLine("Digite a idade:");
int idade = int.Parse(Console.ReadLine());

if (idade >= 0 && idade <= 12)
{
    Console.WriteLine("Classificação: infantil");
}
else if (idade >= 13 && idade <= 17)
{
    Console.WriteLine("Classificação: adolescente");
}
else if (idade >= 18 && idade <= 59)
{
    Console.WriteLine("Classificação: adulto");
}
else
{
    Console.WriteLine("Classificação: idoso");
}


// Switch

//1. 

Console.WriteLine("Digite o primeiro numero");
int valor1 = int.Parse(Console.ReadLine());

Console.WriteLine("Dgiite o Segundo Numero");
int valor2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a operacao (+, -, *, /)");
char operacao = Console.ReadLine().First<char>();

int resultado = 0;


switch (operacao)
{
    case '+':

        resultado = valor1 + valor2;
        Console.WriteLine($"Resultado: {resultado}");
        break;

    case '-':

        resultado = valor1 - valor2;
        Console.WriteLine($"Resultado: {resultado}");
        break;

    case '*':

        resultado = valor1 * valor2;
        Console.WriteLine($"Resultado: {resultado}");
        break;

    case '/':

        resultado = valor1 / valor2;
        Console.WriteLine($"Resultado: {resultado}");
        break;

    default:

        Console.WriteLine("Valor invalido tente novamente");
        break;


}


//2.

Console.WriteLine("1- Manha \n2- Tarde \n3- Noite");
Console.WriteLine("\nque momento do dia e agora?:");


int momentodoDia = int.Parse(Console.ReadLine()!);

Console.WriteLine("Qual o seu nome?");

string nome = Console.ReadLine();   

switch(momentodoDia)
{
    case 1:

        Console.WriteLine($"Bom dia, {nome}");
        break;

    case 2:

        Console.WriteLine($"Boa Tarde, {nome}");
        break;

    case 3:

        Console.WriteLine($"Boa Noite, {nome}");
        break;

    default:
        Console.WriteLine("Numero errado");
        break;

}


//3.

Console.WriteLine("Digite o Codigo de recompensa ( DOBRAR, CURAR, OURO, ESPECIAL: ");
string recompensa = Console.ReadLine()!.ToUpper();

string item = recompensa;

 item = recompensa switch
{
    "DOBRAR" => "Ganhar 2x EXP por 1 hora.",
    "CURAR" => "Poção de cura.",
    "OURO" => "1000 moedas de ouro.",
    "ESPECIAL" => "Item lendario."
};
Console.WriteLine($"{item} desbloqueado!");


//4.

Console.WriteLine("Digite o codigo do livro: ");
Console.WriteLine(""""
     
    1: Ficção Científica
    2: Literatura Clássica
    3: Fantasia
    4: Romance
    5: Suspense/Mistério
    6: Não ficção
    7: Biografias/Memórias
    8: Distopia
    9: Infantojuvenil
    
    """");

char codigo = Console.ReadLine()!.First<char>();

switch (codigo)
{
    case '1':
        Console.WriteLine("Ficção Científica");
        break;

    case '2':
        Console.WriteLine("Literatura Clássica");
        break;

    case '3':
        Console.WriteLine("Fantasia"); 
        break;

    case '4':
        Console.WriteLine("Romance");
        break;

    case '5':
        Console.WriteLine("Suspense/Mistério");
        break;

    case '6':
        Console.WriteLine("Não Ficção");
        break;

    case '7':
        Console.WriteLine("Biografias/Memórias");
        break;

    case '8':
        Console.WriteLine("Distopia");
        break;

    case '9':
        Console.WriteLine("Infantojuvenil");
        break;

    default:
        Console.WriteLine("Código inexistente");
        break;

}

Console.WriteLine(codigo);


//5.

Console.WriteLine("Sistema de Autenticacao\n-----------------------\nDigite seu nome de usuario: "); 
string nome = Console.ReadLine()!.ToLower();
int opcoes = 0;

if (nome == "ulysses")
{
    Console.WriteLine("Bem-vindo, Ulysses!");
}
else
{
    Console.WriteLine(""""

        Usuário não cadastrado.

        Opções disponíveis:
        [1] Cadastrar novo usuário
        [2] Acessar como convidado
        [3] Sair 
        """");

    Console.WriteLine("\nQual opcao deseja escolher? ");
    opcoes = int.Parse(Console.ReadLine());

    switch (opcoes)
    {
        case 1:
            Console.WriteLine($"\nNovo Usuario {nome} Cadastrado com Sucesso!");
            break;

        case 2:
            Console.WriteLine("Acesso consedido como Convidado");
            break;

        case 3:
            Console.WriteLine("Ate logo");
            break;

    }
} 

//=== Lacos de repeticao ===\

//1.

int valores;
int somaValores = 0;

do
{
    Console.WriteLine("Digite o Valor da venda (ou 0 para encerrar): ");
    valores = int.Parse(Console.ReadLine()!);
    somaValores += valores;

} while (valores != 0);

Console.WriteLine($"Total de vendas do dia: {somaValores:c}");


//2.


int quantidade,opcao;
int soma = 0;

Console.WriteLine("""
            Deseja adicionar um produto ao estoque?
            1 - sim | 0 - nao
            """);
opcao = int.Parse(Console.ReadLine()!);


if(opcao == 1)
{
    do
    {
        Console.WriteLine("\nQuantidade: ");
        quantidade = int.Parse(Console.ReadLine()!);
        soma += quantidade;
        Console.WriteLine($"Estoque Atual: {soma}\n");
        Console.WriteLine("""

            Deseja continuar?
            1 - sim | 0 - nao
            """);
        opcao = int.Parse(Console.ReadLine()!);

    } while (opcao != 0);
}



Console.WriteLine("Obrigado por usar nosso sistema de estoque!");



//3.

int nSecreto = 7;
int nDigitado;

do
{
    Console.Write($"Tente adivinhar o número entre 1 e 10: ");
    nDigitado = int.Parse(Console.ReadLine()!);

} while (nDigitado != nSecreto);


    Console.WriteLine("Parabens voce acertou!"); 

//4.

List<string> alunos = new List<string>() { "ana", "carlos", "bianca", "joao", "marina" };

Console.WriteLine("Digite o nome do aluno: ");
string nomeDigitado = Console.ReadLine()!.ToLower();
int indice = 0; 
bool encontrado = false;  



while (indice < alunos.Count)
{
    if(alunos[indice] == nomeDigitado)
    {
        encontrado = true;
        break;
    }

    indice++;
}

if (encontrado)
{
    Console.WriteLine($"Aluno encontrado na posição: {indice}");
}
else
{
    Console.WriteLine("Aluno não está presente na lista");
}


//5


int menu = 0; 
int geradorSenhas = 0;
int senhaAtual = 0;
int senhaGerada = 0;

do
{
    Console.WriteLine(""""

    1 - Gerar nova senha
    2 - Chamar senha Atual 
    3 - Sair 
    """");
    Console.Write($"Escolha uma opcao: ");
    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            GerarSenha();
            break;
        case 2:
            SenhaChamada();
            break;

        case 3:
            EncerrandoSistema();
            break;

        default: Console.WriteLine("Opção inválida.");

            break ;
    }

    menu = opcao;
       
}
while (menu != 3);


int GerarSenha()
{
    senhaGerada++;
    Console.Write($"senha gerada: {senhaGerada.ToString("D3")}\n");
    return 0;
}

int SenhaChamada()
{
    senhaAtual = senhaGerada;
    Console.WriteLine($"Senha chamada: {senhaAtual.ToString("D3")}\n");
    return 0;
}

int EncerrandoSistema()
{
    Console.Clear();
    Console.WriteLine("Encerrando o Sistema");

    return 0;
}


//6.

int menu = 0;
int opcoes = 0; 
double celsiu = 0;
double fahrenheit = 0;

Console.Write("Digite a temperatura em Celsius");

do
{
    Console.Write(""""
    
    1 - Celsius para Fahrenheit
    2 - Fahrenheit para Celsius
    3 - Sair
    Escolha uma opção: 
    """");
    opcoes = int.Parse(Console.ReadLine());

    switch(opcoes)
    {
        case 1:
            Console.Write("\nDigite a temperatura em Celsius: ");
            celsiu = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"{celsiu}'C equivale a {(celsiu * 9 / 5) + 32}'F");
            break;

        case 2:
            Console.Write("\nDigite a temperatura em Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"{fahrenheit}'F equivale a {(fahrenheit - 32) * 5/9}'C");
            break;

        case 3:
            Console.Clear();
            Console.WriteLine("Sistema Encerrado!");
            break;

        default:
            Console.WriteLine("Opcao Invalida");
            break;

    }


} while (opcoes != 3);


    //==For/foreach==\

//1.

for (int i = 1; i <= 20 ; i++)
{
    if( i % 3 != 0 )
    { 
        Console.WriteLine(i);
        
    }

}

//2.

int tabuada = 7;
int total = 0;

for (int i = 1; i <= 10; i++)
{
    total = i * tabuada;
    Console.WriteLine($"{tabuada} x {i} = {total} ");
}

//3.

List<int> notas = new List<int> { 4, 7, 5, 9, 6 };

foreach(var n in notas)
{

    if(n < 6)
    {
        Console.WriteLine($"{n} - Reprovado");
    }
    else
    {
        Console.WriteLine($"{n} - Aprovado");
    }
}

//4.

List<double> notas = new List<double>
        {
    8.5,
    6.2,
    9.1,
    5.8,
    7.4
        };

foreach (double value in notas)
{
    if (value > 7.0) { Console.WriteLine($"O aluno com a nota {value} esta indo muito bem!"); }
    else { Console.WriteLine($"O aluno com a nota {value} est abaixo da media!"); }

}

//5.

int impares = 0;
List<int> nDigitados = new List<int>();

for (int i = 0; i < 10 ;i++)
{
    Console.Write("Digite um numero: ");
    int numeros = int.Parse(Console.ReadLine()!);
    nDigitados.Add(numeros);

    if (i % 2 != 0)
    {
        impares++;
    }
}
Console.WriteLine($"Você digitou {impares} números ímpares.");

*/
