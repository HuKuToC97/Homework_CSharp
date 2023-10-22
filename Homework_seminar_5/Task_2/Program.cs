// Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых 
// чисел и выводит результат на экран.
// Программа должна иметь метод SumOddElements, который принимает массив целых чисел и возвращает 
// сумму элементов с нечетными индексами в массиве.
// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
// При выводе элементы массива должны быть разделены символом табуляции "\t".



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
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write("\t" + array[i]);
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

int SumOddElements(int[] array)
{
    int sumOddElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sumOddElements += array[i];
        }
    }
    return sumOddElements;
}


int[] myArray = GenerateMassine(4, 100, 999);
int[] testArray = { 4, 6, 8, 7, 8 };

PrintArray(myArray);
int evenCount = PositiveNumbersInAnArray(myArray);
Console.WriteLine($"Количество четных элементов: {evenCount}");
int sumOdd = SumOddElements(myArray);
Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");

PrintArray(testArray);
evenCount = PositiveNumbersInAnArray(testArray);
Console.WriteLine($"Количество четных элементов: {evenCount}");
sumOdd = SumOddElements(testArray);
Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
