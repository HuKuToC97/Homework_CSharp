// Напишите программу, которая подсчитывает количество четных элементов 
// в массиве целых 
// положительных трехзначных чисел и выводит результат на экран.

int[] GenerateMassine(int length, int minValue, int maxValue)
{
    int[] numbersMassive = new int[length];
    Random random = new Random();
    for (int i = 0; i < numbersMassive.Length; i++)
    {
        numbersMassive[i] = random.Next(minValue, maxValue + 1);
    }
    return numbersMassive;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}

int PositiveNumbersInAnArray(int[] array)
{
    int positiveNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            positiveNumbers += 1;
        }
    }
    return positiveNumbers;
}


int[] myArray = GenerateMassine(4, 100, 999);
int[] testArray = { 4, 6, 8, 7, 8 };

PrintArray(myArray);
int evenCount = PositiveNumbersInAnArray(myArray);
Console.WriteLine($"Количество четных элементов: {evenCount}");

PrintArray(testArray);
evenCount = PositiveNumbersInAnArray(testArray);
Console.WriteLine($"Количество четных элементов: {evenCount}");