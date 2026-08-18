double salarioBruto, inss;

Console.Write("Digite o valor do seu sálario bruto: ");
salarioBruto = double.Parse(Console.ReadLine());

inss = salarioBruto * 0.11;

Console.WriteLine($"Com o sálario de valor R${salarioBruto} o valor do INSS é {inss.ToString("C")}");

Console.ReadKey();