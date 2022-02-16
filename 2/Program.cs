// По двум заданным числам проверять, 
// является ли первое квадратом второго

int a, b;
string str;

// Console.Clear();
Console.Write("Введите первое число: ");
str = Console.ReadLine();
a = Convert.ToInt32(str);

Console.Write("Введите второе число: ");
str = Console.ReadLine();
b = Convert.ToInt32(str);

if (a == b*b) 
{
    Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else
{
    Console.WriteLine($"Число {a} не является квадратом числа {b}");
 
}