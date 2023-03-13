//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
//сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int Prompt(string massage)
{
  System.Console.Write(massage);
  string ReadInput = System.Console.ReadLine();
  int result = Convert.ToInt32(ReadInput);
  return result;
}
int SumNumbers(int m, int n)
{
  if (m <= 0 || n <= 0 || n < m) return 0;
  else
  {
    if (m == n) return n;
    else return n + SumNumbers(m, n - 1);
  }
}
int m = Prompt("Введите положительное значение M:  ");
int n = Prompt("Введите положительное значение N больше М:  ");
Console.WriteLine(SumNumbers(m, n));
