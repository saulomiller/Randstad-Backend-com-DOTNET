using Randstad_Backend_com_DOTNET.models;



Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
        case "a":
        case "e":
        case "i":
        case "o":
        case "u":
                Console.WriteLine("Vogal");
                break;
        default:
                Console.WriteLine("Nao e uma vogal.");
                break;        
}


























// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 10;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque:{quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"E possivel realizar a venda? {possivelVenda}");




//  if (quantidadeCompra == 0)
// {
//         Console.WriteLine("Venda invalida.");
// }
 
// else if (possivelVenda)
// {
//         Console.WriteLine("Venda realizada.");
// } 
 
 
//  else
// {
//         Console.WriteLine("Desculpe. Nao temos a quantidade em estoque.");
// }

// string a = "15";

// int b = 0;
// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Conversao realizada com sucesso!");






// double a = 4 / (2 + 2);
// Console.WriteLine(a);



// int a = int.MaxValue;  
// int b = a;


// Console.WriteLine(b);






//long a = long.MaxValue;
// int b = Convert.ToInt32(a);



// int a = 5;
// double b = a;



//int a = Convert.ToInt32(null);
// int a = int.Parse(null);



// int a = 10; 
// int b = 20;

// int c = a + b;

// c = c + 5;

// c += 5;


// DateTime dataAtual = DateTime.Now;
// Console.WriteLine("sao " + dataAtual .ToString("dd/MM/yyyy HH:mm"));



// string apresentacao = "Ola, seja bem vindo";

// int quantidade = 1;
// quantidade = 10;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;



// Console.WriteLine(apresentacao);
//Console.WriteLine("Valor da variavel quantidade: " + quantidade);
// Console.WriteLine("Valor da variavel altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variavel preco: " + preco);
// Console.WriteLine("Valor da variavel condicao: " + condicao);




//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Saulo";
//pessoa1.Idade = 26;
//pessoa1.Apresentar();