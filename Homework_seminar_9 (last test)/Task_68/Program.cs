// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int CalculationOfTheAckermannFunction(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if (numberM > 0 && numberN == 0)
    {
        return CalculationOfTheAckermannFunction(numberM - 1, 1);
    }
    else
    {
        return CalculationOfTheAckermannFunction(numberM - 1, CalculationOfTheAckermannFunction(numberM, numberN - 1));
    }
}

int ReadConsoleToInt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}


System.Console.Clear();
System.Console.WriteLine("Данная программа вычислит функцию Аккермана для двух натуральных чисел M и N");
int firstNumber = ReadConsoleToInt($"Введите первое число (m): ");
int secondNumber = ReadConsoleToInt($"Введите второе число (n): ");
if (firstNumber > 0 && secondNumber > 0)
{
    System.Console.WriteLine($"\nФункция Аккермана A(m,n) для двух натуральных чисел m({firstNumber}) и n({secondNumber}) равна:\nA({firstNumber},{secondNumber}) = {CalculationOfTheAckermannFunction(firstNumber, secondNumber)}\n");
}
else
{
    System.Console.WriteLine("Введены некорректные значения");
}