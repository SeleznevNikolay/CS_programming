// Выяснить, кратно ли число заданному, если нет, вывести остаток

int a = 32425;
int b = 25;

if (a%b == 0) 
    System.Console.WriteLine($"Число {a} кратно {b}");
else System.Console.WriteLine(
    $"Остаток от деления числа {a} на число {b} равен {a%b}");