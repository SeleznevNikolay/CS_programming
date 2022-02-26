// Удалить вторую цифру трёхзначного числа

int number = 597;

int temp = number%10;
number = (number/100) * 10 + temp;
System.Console.WriteLine(number);
