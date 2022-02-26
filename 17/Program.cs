// По двум заданным числам проверять является ли одно квадратом другого

int a = 64;
int b = 8;

VerifySquare(a, b);

void VerifySquare(int x, int y)
{
    if (x == y*y) System.Console.WriteLine(
        $"Число {x} квадрат числа {y}"
        );
    else
        if (y == x*x) System.Console.WriteLine(
            $"Число {y} квадрат числа {x}"
            );
        else System.Console.WriteLine(
            $"Числа {x} и {y} не являются квадратами друг друга"
            );
}
