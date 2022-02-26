// Показать четные числа от 1 до N

int numberN = 31;

int i = 1;
while (i <= numberN)
{
    if (i%2 == 0) Console.Write($"{i} ");
    i++;
}
// for (int i = 1; i <= numberN; i++)
// {
//     if (i%2 == 0) Console.Write($"{i} ");
// }
