// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = Numbers("Введите n: ");
int count = 2;
Print(n, count);
Console.Write(1);

void Print(int n, int count)
{
  if (count > n) return;
  Print(n, count + 1);
  Console.Write(count + ", ");
}

int Numbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
