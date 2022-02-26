// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = 62;

if (number%10 > number/10)
    System.Console.WriteLine($"{number%10}");
else System.Console.WriteLine($"{number/10}");
