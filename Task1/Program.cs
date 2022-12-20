Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int result = (number/10) - (number/100)*10;
Console.WriteLine ($"{number} -> {result}");

