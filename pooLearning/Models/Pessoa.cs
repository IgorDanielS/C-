using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        
        public void Apresentar()
        {
            Console.Write($"Meu nome é {Nome} e eu tenho {Idade} anos. ");
        }
    }
}