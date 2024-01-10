using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.Models;

namespace learning.Models
{
    public class Cursos
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int QtdAlunosMatriculados()
        {
            int qtd = Alunos.Count();
            return qtd;
        }
        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAluno()
        {
            Console.WriteLine($"Alunos do curso {Nome}");
            for(int count = 0; count < Alunos.Count; count++)
            {
                string texto = $"N {count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
                Console.WriteLine(Alunos.Count);
            }
        }
    }
}