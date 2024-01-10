using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using poo.Models;

namespace pooLearning.Models
{
    // : significa q uma classe está herdando de outra, nesse caso Aluno herda propriedades de Pessoa
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Sou o aluno {Nome} e tenho a nota {Nota}");
        }
    }
}