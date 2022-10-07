// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите 5-ти значное число: ");
string a = Console.ReadLine();
int Length = a.Length;
if (Length==5)
{
    if(a[0]==a[4] && a[1]==a[3])
    {
    Console.WriteLine("Палиндром");
    }
    else
    {
    Console.WriteLine("Не палиндром");   
    }
}
else
{
    Console.WriteLine("Не является 5-ти значным числом");
}