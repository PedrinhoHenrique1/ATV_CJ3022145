//Atividade 1
using System.ComponentModel.Design;

Console.WriteLine("Atividade 1");
Console.WriteLine("Digite úm número: ");
int num = int.Parse(Console.ReadLine());

if ((num % 2 == 0))
{
    Console.WriteLine("O número é par.");
}

//Atividade 2
Console.WriteLine("Atividade 2");
Console.WriteLine("Digite o comprimento 1: ");
int comp1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digtite o comprimento 2: ");
int comp2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o comprimento 3: ");
int comp3 = int.Parse(Console.ReadLine());

if (comp1 == comp2 && comp2 == comp3)
{
    Console.WriteLine("O triângulo é equilátero.");
}

else if (comp1 != comp2 && comp2 == comp3)
{
    Console.WriteLine("O triângulo é isóseceles.");
}

else if (comp1 != comp2 && comp2 != comp3)
{
    Console.WriteLine("O triângulo é escaleno.");
}

else
{
    Console.WriteLine("Os comprimentos inseridos não formam um triângulo.");
}

//Atividade 3
Console.WriteLine("Atividade 3");
Random random = new Random();
int numeroAleatorio = random.Next(1, 101);
int tentativas = 0;

while (tentativas < 3)
{
    Console.WriteLine("Tente adivinhar um número entre 1 e 100:");
    int tentativa = int.Parse(Console.ReadLine());
    tentativas++;

    if (tentativa > numeroAleatorio)
    {
        Console.WriteLine("Seu palpite foi maior. Tente novamente.");
    }
    else if (tentativa < numeroAleatorio)
    {
        Console.WriteLine("Seu palpite foi menor. Tente novamente.");
    }
    else
    {
        Console.WriteLine("Parabéns! Você acertou o número.");
        return;
    }
}

Console.WriteLine($"O número era {numeroAleatorio}.");

//Atividade 4

Console.WriteLine("Atividade 4");
Console.WriteLine("Insira o nome de usuário:");
string username = Console.ReadLine();

Console.WriteLine("Insira a senha:");
string password = Console.ReadLine();

if (username == "admin" && password == "admin123")
{
    Console.WriteLine("Acesso concedido.");
}
else
{
    Console.WriteLine("Acesso negado.");
}

//Atividade 5
Console.WriteLine("Atividade 5");
Console.WriteLine("Insira uma nota de 0 até 100: ");
int not = int.Parse(Console.ReadLine());

if (not < 60)
{
    Console.WriteLine("Sua nota é F");
}
else (not > 60 && not < 69)
{
    Console.WriteLine("Sua nota é D");
}
else if (not > 70 && not < 79)
{
    Console.WriteLine("Sua nota é C");
}
else if (not > 80 && not < 89)
{
    Console.WriteLine("Sua nota é B");
}
else if (not > 90 && not < 100)
{
    Console.WriteLine("A sua nota é A");
}
else (Console.WriteLine("A nota inserida é inválida")



    //Atividade 6
    Random random = new Random();

string[] opcoes = { "Pedra", "Papel", "Tesoura" };

Console.WriteLine("Escolha uma opção:\n1. Pedra\n2. Papel\n3. Tesoura");
int escolha_usu = int.Parse(Console.ReadLine()) - 1;

if (escolha_usu < 0 || escolha_usu >= opcoes.Length)
{
    Console.WriteLine("Opção inválida. Tente novamente.");
    return;
}

int escolhaComputador = random.Next(opcoes.Length);

Console.WriteLine($"Você escolheu: {opcoes[escolhaUsuario]}");
Console.WriteLine($"O computador escolheu: {opcoes[escolhaComputador]}");

if (escolha_usu == escolhaComputador)
{
    Console.WriteLine("Empate!");
}
else if ((escolhaUsuario == 0 && escolhaComputador == 2) ||
         (escolhaUsuario == 1 && escolhaComputador == 0) ||
         (escolhaUsuario == 2 && escolhaComputador == 1))
{
    Console.WriteLine("Você ganhou!");
}
else
{
    Console.WriteLine("Você perdeu!");
}
}

    //Atividade 7
    Console.Write("Insira o valor total da compra: ");
double valorTotal = Convert.ToDouble(Console.ReadLine());

double desconto = 0;
if (valorTotal > 100 && valorTotal <= 200)
{
    desconto = 0.1; // 10% de desconto
}
else if (valorTotal > 200 && valorTotal <= 300)
{
    desconto = 0.2; // 20% de desconto
}
else if (valorTotal > 300 && valorTotal <= 400)
{
    desconto = 0.3; // 30% de desconto
}
else if (valorTotal > 400)
{
    desconto = 0.4; // 40% de desconto
}

float valorComDesconto = valorTotal - (valorTotal * desconto);

Console.WriteLine($"Valor total com desconto: R${valorComDesconto:F2}");

Console.Write("Insira seu peso (em kg): ");
float peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira sua altura (em metros): ");
float altura = Convert.ToDouble(Console.ReadLine());

float imc = peso / (altura * altura);

string categoria;
if (imc < 18.5)
{
    categoria = "Abaixo do peso";
}
else if (imc < 25)
{
    categoria = "Peso normal";
}
else if (imc < 30)
{
    categoria = "Sobrepeso";
}
else if (imc < 35)
{
    categoria = "Obesidade grau I";
}
else if (imc < 40)
{
    categoria = "Obesidade grau II";
}
else
{
    categoria = "Obesidade grau III";
}

Console.WriteLine($"Seu IMC é: {imc:F2}");
Console.WriteLine($"Categoria: {categoria}");
}
