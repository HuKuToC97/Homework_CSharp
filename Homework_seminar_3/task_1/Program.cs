// который принимает на вход пятизначное число number и проверяет, 
// является ли оно палиндромом.
// Метод должен проверить является ли число пятизначным, 
// в противном случае - вывести Число не пятизначное и False 
// в следующей строке.

// Для остальных чисел вернуть True или False.

bool IsPalindrome(int usernumber)
{
    bool aRangeCheck = (usernumber < 10000 || usernumber > 99999);
    bool polindromCheck = (usernumber % 10 == usernumber / 10000 % 10) && (usernumber / 10 % 10 == usernumber / 1000 % 10);
    if (aRangeCheck)
    {
        System.Console.WriteLine("Число не пятизначное");
        return(!aRangeCheck);
    }
    else
    {
        return(polindromCheck);
    }
}

int usernumber = int.Parse(System.Console.ReadLine());
bool result = IsPalindrome(usernumber);
System.Console.WriteLine($"{result}");