using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using poo.Models;

namespace pooLearning.Models
{
    
    public class Professor : Pessoa
    {
        public Professor()
        {

        }
        public Professor(string nome) : base(nome)
        {
            
        }
        // : significa q uma classe está herdando de outra, nesse caso Aluno herda propriedades de Pessoa
        public decimal Salario { get; set; }
        //o OVERRIDE serve pra sobrescrever uma funcao (poliformismo)
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho um salário de {Salario}");
        }
    }
}