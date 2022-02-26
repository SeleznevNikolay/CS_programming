// Дано число обозначающее день недели.
// Выяснить является номер дня недели выходным

int numberDay = 7; // 1 ... 7
WeekEnd(numberDay);

void WeekEnd(int x)
{
    if (x == 6 || x ==7)
        System.Console.WriteLine("Ура, выходной!");
    else System.Console.WriteLine("Еще работаем (");
}