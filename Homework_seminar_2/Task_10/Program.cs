// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    string userNumberForParse = Console.ReadLine();
    int userNumber;
    userNumber = int.Parse(userNumberForParse);
    return userNumber;
}
int userNumber = ReadInt("Введите число:");
int secondNumber = userNumber /10 % 10;
System.Console.WriteLine(secondNumber);
