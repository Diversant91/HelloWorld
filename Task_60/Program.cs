// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Array3D = new int[2, 2, 2];
FillArray(Array3D);
PrintArray(Array3D);


void FillArray(int[,,] Arr)
{
    int count = 10;
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            for (int k = 0; k < Arr.GetLength(2); k++)
            {
                Arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}
 
void PrintArray(int[,,] Arr)
{
    for (int i = 0; i < Array3D.GetLength(0); i++)
    {
        for (int j = 0; j < Array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < Array3D.GetLength(2); k++)
            {
                Console.Write($"{Array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

