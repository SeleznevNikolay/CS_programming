// Дано число. Проверить кратно ли оно 7 и 23

int number = 46;
Div7and23(number);

void Div7and23(int x)
{
    if (x%7 == 0)
        if (x%23 == 0) System.Console.WriteLine(
            $"Число {x} делится на 7 и на 23"
        );
        else System.Console.WriteLine(
            $"Число {x} не делится на 7 и на 23"
            );
    else System.Console.WriteLine(
        $"Число {x} не делится на 7 и на 23"
    );
}
