// на вход число N, на выходе таблица квадратов чисел от 1 до N

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int square = 1;

while (square<=N)
{
    Console.WriteLine(Math.Pow(square, 2));
    square++;
}