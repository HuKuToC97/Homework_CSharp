// Задача 25: Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string message)
{
    System.Console.Write(message + "  "); // Получаем данные из строки.
    System.Console.WriteLine();
    string value = Console.ReadLine(); // Вызов консольного ввода, value - значение, которое вводим.
    return int.Parse(value);
}

int userNumber = ReadInt("Введите число:");
int degree = ReadInt("Введите степень:");
System.Console.WriteLine(Math.Pow(userNumber,degree));