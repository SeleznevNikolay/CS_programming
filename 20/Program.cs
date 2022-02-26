// Задать номер четверти, показать диапазоны для возможных координат

int numberQuarter = 3; // 1, 2, 3, 4
RangeCoordinate(numberQuarter);

void RangeCoordinate(int nQuart)
{
    if (nQuart == 1) System.Console.WriteLine(
        "Кординаты 1-й четверти в диапазоне: X > 0 , Y > 0"
    );
    if (nQuart == 2) System.Console.WriteLine(
        "Кординаты 2-й четверти в диапазоне: X < 0 , Y > 0"
    );
    if (nQuart == 3) System.Console.WriteLine(
        "Кординаты 3-й четверти в диапазоне: X < 0 , Y < 0"
    );
    if (nQuart == 4) System.Console.WriteLine(
        "Кординаты 4-й четверти в диапазоне: X > 0 , Y < 0"
    );
}
