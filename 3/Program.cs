// Даны два числа. Показать большее и меньшее число

int a, b;
string str;

Console.Write("Введите число a: ");
str = Console.ReadLine();
a = Convert.ToInt32(str);

Console.Write("Введите число b: ");
str = Console.ReadLine();
b = Convert.ToInt32(str);

if (a > b) Console.WriteLine($"Число {a} большее, число {b} меньшее.");
if (a < b) Console.WriteLine($"Число {b} большее, число {a} меньшее.");
if (a == b) Console.WriteLine($"Число {a} равно числу {b}.");
