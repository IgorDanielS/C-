using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        public Pessoa(string nome)
        {  
            Nome = nome;
        }
    
        public string Nome { get; set; }
        public int Idade { get; set; }
        //A palavra chave "VIRTUAL" serve para permitir a sobrescrição em outras funcoes (poliformismo)
        public virtual void Apresentar()
        {
            Console.Write($"Meu nome é {Nome} e eu tenho {Idade} anos. ");
        }
    }
}