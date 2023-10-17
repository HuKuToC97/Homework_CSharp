
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string message)
{
    System.Console.Write(message + "  "); // Получаем данные из строки.
    string value = Console.ReadLine(); // Вызов консольного ввода, value - значение, которое вводим.
    return int.Parse(value);
}

int userNumber = ReadInt("Введите число:");
int sum = 0;
for (sum = 0; userNumber > 0; userNumber /= 10)
{
    sum += userNumber % 10;
}
System.Console.WriteLine(sum);