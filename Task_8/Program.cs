﻿Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <=a)
{
    if (count % 2 ==0)
    {
        Console.Write(count + ", ");
    }
    count++;

}

