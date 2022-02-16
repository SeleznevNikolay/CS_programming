// 
int a;
int b;
int sum;
string s;

Console.Clear();
Console.Write("Введите чисто a: ");
s = Console.ReadLine();
a = Convert.ToInt32(s);
Console.Write("Введите число b: ");
s = Console.ReadLine();
b = Convert.ToInt32(s);
sum = a + b;
System.Console.WriteLine($"{a} + {b} = {sum}");


System.Console.WriteLine();
