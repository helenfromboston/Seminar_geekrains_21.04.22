Console.Write("Введите координату X: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y: ");
int Y = int.Parse(Console.ReadLine());

if (X == 0 || Y == 0) Console.WriteLine("Координаты не принадлежат конкретной плоскости");
else if (X > 0 && Y > 0) Console.WriteLine("Координаты принадлежат первой четверти");
else if (X < 0 && Y > 0) Console.WriteLine("Координаты принадлежат второй четверти");
else if (X < 0 && Y < 0) Console.WriteLine("Координаты принадлежат третьей четверти");
else if (X > 0 && Y < 0) Console.WriteLine("Координаты принадлежат четвёртой четверти");