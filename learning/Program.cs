using System.Reflection.Metadata;
using dotnet.Models;
using learning.Models;
using System;

using System;
using System;

class Program
{
    static void Main()
    {
        // Solicita o nome do usuário, quilômetros percorridos por dia, 
       // Horas de uso de eletrônicos por dia e o número de refeições com carne:
       string nome = Console.ReadLine();
       double quilometrosPorDia = double.Parse(Console.ReadLine());
       int horasDeEletronicos = int.Parse(Console.ReadLine());
       int refeicoesComCarne = int.Parse(Console.ReadLine());

        // Chama o método para calcular a pegada de carbono
        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
        
        // TODO: Exiba o resultado para o usuário:
        Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

        // Aguarda a entrada do usuário antes de encerrar o programa:
        Console.ReadLine();
    }
    public static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
    {
      double retorno;
      retorno = (quilometrosPorDia * 365 * 0.2) + (horasDeEletronicos * 0.1) + (refeicoesComCarne * 0.5);
      return retorno;
    }

    // TODO: Crie um método/função para calcular a pegada de carbono com base nos parâmetros fornecidos:
  

}



 // Caso a descricao esteja dentro do limite é solicitado a entrada pelo console:
 // TODO: Imprima a descricao e a data de vencimento como nos exemplos da tabela:            
          

//  Pessoa p1 = new Pessoa("Igor", "Daniel");
// Pessoa p1 = new Pessoa(nome:"Igor", sobrenome:"Daniel");
// p1.Nome = "Igor";
// p1.Sobrenome = "Daniel";

// Pessoa p2 = new Pessoa("José", "Daniels");
// p2.Nome = "José";
// p2.Sobrenome = "Daniels";


// Cursos programacao = new Cursos();
// programacao.Nome = "C#";
// programacao.Alunos = new List<Pessoa>();

// programacao.AdicionarAluno(p1);
// programacao.AdicionarAluno(p2);
// programacao.ListarAluno();
// programacao.RemoverAluno(p1);
// programacao.ListarAluno();


// DateTime: 
// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
// Console.WriteLine(dataAtual.ToShortTimeString());

//Setando uma nova localização pro sistema:
// using System.Globalization;
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1520.40M;

// Console.WriteLine($"{valorMonetario:C}");
// Outro formato de colocar o valor em uma localização:
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// double porcentagem = .12321;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 12156;
// Console.WriteLine(numero.ToString("##-##-##"));

//Conversor:
// int a = Convert.ToInt32("5");
// int a = int.Parse("5");

// int a = 5;
// string b = a.ToString();
// Console.WriteLine(b);


//Condicional
// OR ||
// bool maiorIdade = true;
// bool autorizacao = false;

// if(maiorIdade || autorizacao){
//     Console.WriteLine("Pronto pra a viagem!");
// }else{
//     Console.WriteLine("Tchau! Não vai viajar! ");
// }

//AND &&
// bool presenca = true;
// double media = 7.1;

// if(presenca && media > 7){
//     Console.WriteLine("Passou de ano!");
// }else{
//     Console.WriteLine("Não passou de ano! ");
// }

//CASE:

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch (letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//     Console.WriteLine("Vogal!");
//     break;
//     default:
//     Console.WriteLine("Consoante!");
//     break;
// }

// NOT !

// bool choveu = false;
// bool estaTarde = false;

// if(!choveu && !estaTarde){
//     Console.WriteLine("Vou pedalar!");
// }else{
//     Console.WriteLine("Amanhã eu pedalo. ");
// }


//ARRAY
// int [] arrayInteiros = new int[4];
// arrayInteiros[0] = 1;
// arrayInteiros[1] = 2;
// arrayInteiros[2] = 3;
// arrayInteiros[3] = 4;
// int [] arrayInteirosDobrado = new int[arrayInteiros.Length*2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// for(int i = 0; i < arrayInteirosDobrado.Length; i++){
//     Console.WriteLine($"Posição {i} do vetor tem valor: {arrayInteirosDobrado[i]}");
// }

// Resize altera o tamanho do vetor em questão, aqui o tamanho dele é dobrado
// Array.Resize(ref arrayInteiros, arraInteiros.length * 2);


//LISTA
// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("PE");
// listaString.Add("BA");
// listaString.Add("MG");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");
// //A capacidade vai adicionando de 4 em 4, quando chega em 4 ele aguarda e se outro elemento for adicionado a capacidade se torna 8, sempre adicionando 4.
// listaString.Add("SR");
// //capacidade virou 8
// listaString.Remove("PE");
// //Remove mas a capacidade continua a mesma