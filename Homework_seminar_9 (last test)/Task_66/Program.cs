// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке 
// от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void PrintNaturalNumbersInGivenInterval(int numberM, int numberN, int sum)
{
    if (numberN < numberM)
    {
    System.Console.WriteLine($"Cумма натуральных элементов в промежутке от M до N равна: {sum}");
        return;
    }
    sum += numberM;
    PrintNaturalNumbersInGivenInterval(numberM+1, numberN, sum);
}

int ReadConsoleToInt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}


System.Console.Clear();
System.Console.WriteLine("Данная рограмма выведет сумму натуральных элементов в промежутке от M до N");
int firstNumber = ReadConsoleToInt($"Введите первое число (M): ");
int numberN = ReadConsoleToInt($"Введите второе число(N): ");
if (firstNumber < numberN && firstNumber > 0 && numberN > 0)
{
    PrintNaturalNumbersInGivenInterval(firstNumber, numberN, 0);
}
else
{
    System.Console.WriteLine("Введены некорректные значения");
}