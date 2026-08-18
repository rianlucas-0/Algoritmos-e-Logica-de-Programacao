int cateto1, cateto2;
double hipotenusa;

Console.WriteLine("Digite o valor do primeiro cateto");
cateto1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do segundo cateto");
cateto2 = int.Parse(Console.ReadLine());

hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

Console.WriteLine(hipotenusa.ToString("0.00"));

Console.ReadKey();