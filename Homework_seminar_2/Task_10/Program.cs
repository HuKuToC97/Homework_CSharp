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
int userNumber = ReadInt("Введите число трехзначное число:");
if (userNumber > 99 && userNumber < 1000)
{
    System.Console.WriteLine($"Втрая цифра числа {userNumber} это {userNumber /10 % 10}");
}
else
{
    System.Console.WriteLine($"{userNumber} <- не трехзначное попробуйте перезапустить программу и ввести число от 100 до 999");
}
