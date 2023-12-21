using System.Runtime.CompilerServices;
using calculadora.Models;


Calculadora calculadora = new Calculadora();


while(true){
    Console.WriteLine("O que você deseja calcular?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Potencia");
    Console.WriteLine("6 - Coseno");
    Console.WriteLine("7 - Seno");
    Console.WriteLine("8 - Tangente");
    Console.WriteLine("9 - Raiz Quadrada");
    Console.WriteLine("10 - Sair");
    int opcao = int.Parse(Console.ReadLine()); 
    Console.Clear();
switch(opcao){
    case 1:
    Console.WriteLine("Digite seu primeiro numero: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite seu segundo numero: ");
    int num2 = int.Parse(Console.ReadLine());
    calculadora.Somar(num1,num2);
    break;
    case 2:
    Console.WriteLine("Digite seu primeiro numero: ");
    int num3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite seu segundo numero: ");
    int num4 = int.Parse(Console.ReadLine());
    calculadora.Subtrair(num3,num4);
    break;
    case 3:
    Console.WriteLine("Digite seu primeiro numero: ");
    int num5 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite seu segundo numero: ");
    int num6 = int.Parse(Console.ReadLine());
    calculadora.Multiplicar(num5,num6);
    
    break;
    case 4:
    Console.WriteLine("Digite o divisor: ");
    int num7 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o dividendo: ");
    int num8 = int.Parse(Console.ReadLine());
    calculadora.Dividir(num7, num8);
    break;
    case 5:
    Console.WriteLine("Digite o número base: ");
    int num9 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a potência ");
    int num10 = int.Parse(Console.ReadLine());
    calculadora.Potencia(num9,num10);
    break;
    case 6:
    Console.WriteLine("Digite o angulo: ");
    double angulo = double.Parse(Console.ReadLine());
    calculadora.Coseno(angulo);
    break;
    case 7:
    Console.WriteLine("Digite o angulo: ");
    double anguloS = double.Parse(Console.ReadLine());
    calculadora.Seno(anguloS);
    break;
    case 8:
    Console.WriteLine("Digite o angulo: ");
    double anguloT = double.Parse(Console.ReadLine());
    calculadora.Tangente(anguloT);
    break;
    case 9:
    Console.WriteLine("Digite o número para obter a raiz dele: ");
    double raiz = double.Parse(Console.ReadLine());
    calculadora.RaizQ(raiz);
    break;
    case 10:
    Console.WriteLine("Encerrando");
    Environment.Exit(0);
    break;
    default:
    Console.WriteLine("Opção inválida");
    break;
    }
}

