// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    string userNumberForParse = Console.ReadLine();
    int userNumber;
    userNumber = int.Parse(userNumberForParse);
    return userNumber;
}

int ReversalNumber(int normalNumber)
{
    int reversalNumber = 0;
    while (normalNumber > 0)
    {
        reversalNumber *= 10;
        reversalNumber += normalNumber % 10;
        normalNumber /= 10;
    }
    System.Console.WriteLine(reversalNumber);
    return reversalNumber;
}

int userNumber = ReadInt("Введите число:");
int reversalNumber = ReversalNumber(userNumber);

if (userNumber > 99) /// НАДО ДЕЛАТЬ ЧЕРЕЗ МАССИВ
{
    if (userNumber % 10 == 0)
    {
        System.Console.WriteLine();
    }
    else
    {
        System.Console.WriteLine(reversalNumber / 100 % 10);
    }
}
else
{
    System.Console.WriteLine("третьей цифры нет");
}