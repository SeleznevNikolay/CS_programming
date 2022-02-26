// Программа проверяет пятизначное число на палиндромом.

int number = 12321;

Console.WriteLine(VeryfyPalindrome(number));

bool VeryfyPalindrome(int n)
{   
    if (n%10 == n/10000)
        {
            n = n % 10000;
            n = n / 10;
            // System.Console.WriteLine(n);
            if (n%10 == n/100) return true;
            else return false;
        }
    else return false; 
}

