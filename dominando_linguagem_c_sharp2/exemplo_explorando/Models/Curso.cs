using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_explorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        // propriedade do tipo 'coleção'
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados() // assinatura do método
        {
            int quantidade = Alunos.Count; // que vai retornar o numero de elementos dentro da lista;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}