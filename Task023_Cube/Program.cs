// на вход число N, на выходе таблица кубов чисел от 1 до N

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int cube = 1;

while (cube<=N)
{
    Console.WriteLine(Math.Pow(cube, 3));
    cube++;
}