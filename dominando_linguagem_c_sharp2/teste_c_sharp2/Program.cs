using System.Diagnostics.Contracts;
using teste_c_sharp2.Models;

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("yyyy/MM/dd"));

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Tay";
// pessoa1.Idade = 28;
// pessoa1.Apresentar();

// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos em estoque.");
// }
// Calculadora calc = new Calculadora(); //instanciando a classe Calculadora.

// calc.Somar(2, 4);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(36);

// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }


// int numDigitado = 144;

// do
// {
//     Console.WriteLine("Digite a senha: ");
//     numDigitado = Convert.ToInt32(Console.ReadLine());
//     if(numDigitado != 144){
//         Console.WriteLine("Acesso negado!");
//     }

// }
// while(numDigitado != 144);
// Console.WriteLine($"Acesso permitido!");

// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//      Console.Clear(); // para não ficar repetindo o menu;
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - CADASTRAR CLIENTE");
//     Console.WriteLine("2 - BUSCAR CLIENTE");
//     Console.WriteLine("3 - APAGAR CLIENTE");
//     Console.WriteLine("4 - ENCERRAR");


//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//         Console.WriteLine("Cadastro");
//         break;

//         case "2":
//         Console.WriteLine("Busca");
//         break;

//         case "3":
//         Console.WriteLine("Apaga");
//         break;

//         case "4":
//         Console.WriteLine("Sair");
//         // Environment.Exit(0);
//         exibirMenu = false;
//         break;

//         default: 
//         Console.WriteLine("Opção inválida");
//         break;
//     }

// }

// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 4;
// arrayInteiros[1] = 44;
// arrayInteiros[2] = 47;

// // for( int contador = 0; contador < arrayInteiros.Length; contador++)
// // {
// // Console.WriteLine($"array de inteiros: {contador} - {arrayInteiros[contador]}");
// // }

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


//Percorrendo o array com FOREACH: DESVANTAGEM - nao tem acesso ao contador, então é preciso colocar seu valor por fora.
// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição nº {contadorForeach} - {valor}");
//     contadorForeach++;
// }


List<string> listaString = new List<string>();

listaString.Add("PE");
listaString.Add("PB");
listaString.Add("PI");

listaString.Add("MG");
listaString.Add("SP");

for(int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {listaString[contador]} - {listaString.Capacity}");
    if(contador == 4){
        Console.WriteLine("\n");
    }
}




int contadorForeach = 0;
foreach(string item in listaString)
{
    Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
    contadorForeach++;
}