// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] First = new int[2, 2];
FillArrayRandomNumbers(First);
Console.WriteLine($"Первая матрица:");
PrintArray(First);

int[,] Secomd = new int[2, 2];
FillArrayRandomNumbers(Secomd);
Console.WriteLine($"Вторая матрица:");
PrintArray(Secomd);

int[,] Result = new int[2,2];
Total(First, Secomd, Result);
Console.WriteLine($"Произведение двух матриц:");
PrintArray(Result);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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

void Total(int[,] First, int[,] Secomd, int[,] Result)
{
  for (int i = 0; i < Result.GetLength(0); i++)
  {
    for (int j = 0; j < Result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < First.GetLength(1); k++)
      {
        sum += First[i,k] * Secomd[k,j];
      }
      Result[i,j] = sum;
    }
  }
}