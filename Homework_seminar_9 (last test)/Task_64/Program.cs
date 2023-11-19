// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет 
// все чётные натуральные числа в промежутке 
// от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void PrintNaturalNumbersInGivenInterval(int numberM, int numberN)
{
    if (numberN <= numberM)
    {
        return;
    }
    if (numberN % 2 == 1)
    {
        numberN--;
    }
    PrintNaturalNumbersInGivenInterval(numberM, numberN - 2);
    System.Console.Write($"{numberN}\t");
}

int ReadConsoleToInt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}


System.Console.Clear();
System.Console.WriteLine("Данная рограмма выведет все чётные натуральные числа в промежутке от M до N");
int numberM = ReadConsoleToInt($"Введите первое число (M): ");
int numberN = ReadConsoleToInt($"Введите второе число(N): ");
if (numberM < numberN && numberM > 0 && numberN > 0)
{
    PrintNaturalNumbersInGivenInterval(numberM, numberN);
}
else
{
    System.Console.WriteLine("Введены некорректные значения");
}