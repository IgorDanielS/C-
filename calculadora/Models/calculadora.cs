using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x+y}");
        }

        public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} X {y} = {x * y}");
        }
        public void Dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Potencia(int x, int y){
            double pot =  Math.Pow(x,y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }
        public void Seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O seno de {angulo}° é = {seno}");
        }
        public void Coseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O Coseno de {angulo}° é = {coseno}");
        }
        public void Tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"A tangnete de {angulo}° é = {tangente}");
        }
        public void RaizQ(double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}