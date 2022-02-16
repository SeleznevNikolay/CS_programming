// Вывести квадрат числа
//Console.Clear();
Console.Write("Введите число: ");
string str = Console.ReadLine();
int number = Convert.ToInt32(str);
int sqrNumber = number * number;
System.Console.WriteLine($"Квадрат числа {number} = {sqrNumber}");