// Найти максимальное из трех чисел

int a, b, c;

Console.Write("Введите число a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c: ");
c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"Максимальное: {max}");