using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_explorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
    // A classe Pessoa com 2 propriedades:
        private string _nome;
        private int _idade;

        public string Nome 
        { 
            get => _nome.ToUpper(); // body expression para casos de 1 única linha.

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio"); // tratamento de erro se receber vazio; uma exceção pode parar o código e esperar que o erro seja tratado, senão o programa encerra. Nesse caso, se for vazio, o programa encerra após exibir a msg.
                }

                _nome = value; // o value é o valor que passamos; se passa pela validação acima (não está vazio), continua e armazena o valor.
            }
        }    

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade 
        { get => _idade; 
        
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }

                _idade = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, idade: {Idade}");
        }
    }
}