// Найти третью цифру числа или сообщить, что её нет

int number = 374645379;

if (number < 100) System.Console.WriteLine("Третьей цифры нет");
else System.Console.WriteLine
        ($"Третья цифра числа {number} равна {number/100%10}");
