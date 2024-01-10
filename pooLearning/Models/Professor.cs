using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using poo.Models;

namespace pooLearning.Models
{
    public class Professor : Pessoa
    {
        // : significa q uma classe está herdando de outra, nesse caso Aluno herda propriedades de Pessoa
        public decimal Salario { get; set; }
    }
}