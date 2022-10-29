// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [,] Array1= new int[4,4];
FillArrayRandomNumbers(Array1);
PrintArray(Array1);
int [] ArraySum= new int[Array1.GetLength(0)];

for (int i = 0; i < Array1.GetLength(0); i++)
    {   for (int j = 0; j < Array1.GetLength(1); j++)
        {
            ArraySum[i]=ArraySum[i]+Array1[i,j];
                     
        }
    }

int Min=ArraySum[0];
int Num=0;

for (int k=0; k<Array1.GetLength(0); k++)
    {
        if (ArraySum[k]<Min)
        {
            Min=ArraySum[k];
            Num=k;
        }   
    }

Console.WriteLine();
Console.Write($"Номер строки с наименьшей суммой элементов: {Num+1} строка");

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
