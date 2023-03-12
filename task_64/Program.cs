//Задача 64: Задайте значение N. Напишите программу, которая выведет
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt(string massage)
{
  System.Console.Write(massage);
  string ReadInput = System.Console.ReadLine();
  int result = Convert.ToInt32(ReadInput);
    return result;
}
string NaturalNumber(int n)
{
    if (n >= 1) return $"{n} " + NaturalNumber(n - 1);
    else return $"Введите число больше нуля ";
}
int n = Prompt("Введите значение N:  ");
Console.WriteLine(NaturalNumber(n));

