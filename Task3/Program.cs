//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = int.Parse(Console.ReadLine());
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("этот день выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("это не день недели");
  }
  else Console.WriteLine("этот день не выходной");

