Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

if (number < 100000 && number > 9999)
{
    if (number % 10 == number / 10000 && number % 100 / 10 == number / 1000 % 10) Console.Write("Да");
    else Console.Write("Нет");
}
else Console.Write("Введено не пятизначное число");