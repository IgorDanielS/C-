using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pooLearning.Models
{
    public class ContaCorrente
    {

        //Construtor pra receber os valores rapidamente:
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;
        public void Sacar(decimal valor)
        {
            if(saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso.");
            }else
            {
                Console.WriteLine("Saque indisponível. Valor ultrapassa o saldo.");
                Extrato();
            }
            
        }
        public void Extrato(){
            Console.WriteLine($"O saldo da conta {NumeroConta} é de: {saldo}");
        }

    }
}