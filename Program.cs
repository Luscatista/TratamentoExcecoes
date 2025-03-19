using System.Threading.Channels;

int num;
int num2;

//Console.WriteLine("Exercícios Básicos");
//Console.WriteLine("1. Entrada Segura de Números");
//Console.WriteLine("Crie um programa que peça ao usuário para digitar um número inteiro. O programa deve usar `try/catch` para garantir que o usuário insira um número válido.\r\n");
//Console.WriteLine("Erros a serem tratados:");
//Console.WriteLine("Usuário digitar um texto ao invés de um número.");

//try
//{
//    Console.WriteLine("Digite um numero inteiro:");
//    num = int.Parse(Console.ReadLine());
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Erro: Entrada inválida, digite um número inteiro válido.");
//}
//Console.WriteLine();


//Console.WriteLine("2. Divisão Segura");
//Console.WriteLine("Crie um programa que peça dois números ao usuário e divida o primeiro pelo segundo. Use `try/catch` para evitar divisão por zero e entrada inválida.\r\n");
//Console.WriteLine("Erros a serem tratados:");
//Console.WriteLine("Usuário digitar um valor não numérico.");
//Console.WriteLine("Tentativa de divisão por zero.");
//Console.WriteLine();

//try
//{
//    Console.WriteLine("Digite o primeiro numero");
//    num = int.Parse(Console.ReadLine());
//    Console.WriteLine("Digite o segundo numero");
//    num2 = int.Parse(Console.ReadLine());
//    Console.WriteLine($"O resultado da divisao é: {num / num2}");
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Erro: Entrada inválida, digite um número inteiro válido.");
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("Erro: Não é possível dividir por zero.");
//}
//Console.WriteLine();

//Console.WriteLine("3. Validação de Idade");
//Console.WriteLine("Peça ao usuário para inserir sua idade e diga se ele é maior ou menor de idade. Use `try/catch` para evitar entradas inválidas.\r\n");
//Console.WriteLine("Erros a serem tratados:");
//Console.WriteLine("Usuário digitar um texto ao invés de um número.");
//Console.WriteLine("Usuário inserir um número muito grande");
//Console.WriteLine();

//try
//{
//    Console.WriteLine("Digite sua idade.");
//    num = int.Parse(Console.ReadLine());
//    if (num < 0 || num > 120)
//    {
//        throw new ArgumentOutOfRangeException();
//    }
//    if (num >= 18)
//    {
//        Console.WriteLine("É maior de idade.");
//    }
//    else
//    {
//        Console.WriteLine("É menor de idade.");
//    }

//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Erro: Entrada inválida, digite um número inteiro válido.");
//}
//catch (OverflowException ex)
//{
//    Console.WriteLine("Erro: A idade informada está acima do limite possível.");
//}
//catch (ArgumentOutOfRangeException ex)
//{
//    Console.WriteLine("Erro: A idade não pode ser abaixo de 0 ou acima de 120.");
//}
//Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Exercícios Intermediários");
Console.WriteLine("4. Contagem Progressiva Segura");
Console.WriteLine("Peça ao usuário para inserir um número inteiro positivo. O programa deve contar de 1 até esse número. Se a entrada for inválida ou negativa, exiba um erro.\r\n");
Console.WriteLine("Erros a serem tratados:");
Console.WriteLine("Usuário digitar um texto ao invés de um número.");
Console.WriteLine("Usuário inserir um número muito grande.");
Console.WriteLine("Usuário inserir um número negativo.");
Console.WriteLine();


try
{
    Console.WriteLine("Digite um numero positivo");
    num = int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (num < 0)
    {
        throw new ArgumentOutOfRangeException();
    }
    for (int i = 0; i <= num; i++)
    {
        Console.WriteLine(i);
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Erro: Entrada inválida, digite um número inteiro válido.");
}
catch (OverflowException ex)
{
    Console.WriteLine("Erro: O numero informado está acima do limite possível.");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("Erro: o numero nao pode ser negativo.");
}
Console.WriteLine();