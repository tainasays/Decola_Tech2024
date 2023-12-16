using exemplo_explorando.Models;

Pessoa pessoa1 = new Pessoa(nome: "Thayna", sobrenome: "Santana"); // instanciando a classe.
// pessoa1.Nome = "Thay";
// pessoa1.Sobrenome = "Santos";

Pessoa pessoa2 = new Pessoa("Lucas", "Felix");

Curso cursoIngles = new Curso();
cursoIngles.Nome = "Inglês";
cursoIngles.Alunos = new List<Pessoa>(); // é preciso instanciar a lista para que ela não seja nula.

cursoIngles.AdicionarAluno(pessoa1);
cursoIngles.AdicionarAluno(pessoa2);
cursoIngles.ListarAlunos();
// pessoa1.Idade = 28;
// pessoa1.Apresentar();

