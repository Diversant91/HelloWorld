// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] arr = new int[7];

Console.Write("[");

for (int i=0; i < 7; i++)
{
    arr[i]=new Random().Next(0, 100);
    Console.Write(arr[i]+ ", ");
}

for (int i=0; i < 7; i++)
{
    if(i==6)
    Console.Write(arr[i]);
}

Console.Write("]");

