//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
string NumberText = Convert.ToString(number);
if (NumberText.Length > 2)
{
  Console.WriteLine("третья цифра - " + NumberText[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}
