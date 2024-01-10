// See https://aka.ms/new-console-template for more information
using pooLearning.Models;
using poo.Models;
//aplicação de Abstração, ou seja, pegar dados mais necessarios, específicos.
// Pessoa p1 = new Pessoa();
// p1.Nome = "José";
// p1.Idade = 12;
// p1.Apresentar();

//No encapsulamento, alguns dados só podem ser modificados utilizando as funcoes da classe
//por exemplo: não posso sacar um valor diretamente: sacar = 1000, tem que ser pela funcao: c1.sacar = 1000 e a funcão fará todo o trabalho
// ContaCorrente c1 = new ContaCorrente(1231232, 1000);
// c1.Sacar(1200);


//Herança: uma classe herda propriedades de outra classe
// Aluno a1 = new Aluno();
// a1.Nome = "Lucio";
// a1.Idade = 16;
// a1.Nota = 6.10;
// a1.Apresentar();

//Polimorfismo: metodos que são alterados pra uma nova situação, nesse caso, Apresentar era de forma
//simples, apresentando o nome e a idade da Pessoa, agora, o Apresentar diz o nome e o salário do professor em questão.
// Professor pr1 = new Professor();
// pr1.Nome = "Robson";
// pr1.Idade = 43;
// pr1.Salario = 5000;
// pr1.Apresentar();


//CLASSE ABSTRATA: só serve para ter seus atributos herdados, não pode ser instanciada
// a instancia deve ser colocada na classe filha
// Corrente co1 = new Corrente();
// co1.Creditar(200);
// co1.ExibirSaldo();

