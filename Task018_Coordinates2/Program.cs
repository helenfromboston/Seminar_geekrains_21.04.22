// по заданному номеру четверти показывает диапазон возможных координатных точек в этой четверти (x и y)

Console.Write("Введите номер четверти: ");
string Q = Console.ReadLine();

if (Q == "1" || Q.ToLower() == "один") Console.WriteLine("Возможные координаты в данной четверти: x>0 и y>0");
else if (Q == "2" || Q.ToLower() == "два") Console.WriteLine("Возможные координаты в данной четверти: x<0 и y>0");
else if (Q == "3" || Q.ToLower() == "три") Console.WriteLine("Возможные координаты в данной четверти: x<0 и y<0");
else if (Q == "4" || Q.ToLower() == "четыре") Console.WriteLine("Возможные координаты в данной четверти: x>0 и y<0");
else Console.WriteLine("Недействительное значение четверти");