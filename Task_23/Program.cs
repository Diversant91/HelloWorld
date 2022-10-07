Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <=a)
{
    double cube = Math.Pow(count,3);
    Console.Write(cube + ", ");

    count++;
}
