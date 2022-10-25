// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите индекс строки массива: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца массива: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] numbers= new int[5,5];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

if (line >= numbers.GetLength(0)|| column >= numbers.GetLength(1))
{
    Console.Write($"Элемента массива c инексами [{line},{column}] не существует");
}
else
{
    Console.WriteLine($"Элемент на позиции [{line},{column}] = {numbers[line,column]} ");
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

