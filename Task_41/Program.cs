// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Кол-во выводимых чисел: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] a = new int[number];
for (int i = 0; i < number; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
int n = 0;

for (int i = 0; i < number; i++)
{
    if (a[i] > 0) n++;
}
Console.WriteLine($"Больше 0 - > {n}");