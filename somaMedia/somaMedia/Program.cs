int n1, n2, n3, n4, n5, soma;
double media;

Console.WriteLine("Digite o primeiro valor inteiro: ");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor inteiro: ");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro valor inteiro: ");
n3 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o quarto valor inteiro: ");
n4 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o quinto valor inteiro: ");
n5 = int.Parse(Console.ReadLine());

soma = n1 + n2 + n3 + n4 + n5;
media = (double)soma / 5;

Console.WriteLine($"A soma de {n1}, {n2}, {n3}, {n4}, {n5} é: {soma}");
Console.WriteLine($"A média é: {media}");

Console.ReadKey();