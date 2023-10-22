// Напишите программу для работы с массивом вещественных чисел.
// Реализуйте класс ArrayOperations, который содержит следующие статические методы:
// FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и 
// возвращает максимальное число из массива.
// FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и 
// возвращает минимальное число из массива.
// CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход 
// массив вещественных чисел array 
// и возвращает разницу между максимальным и минимальным числами в массиве.
// PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив array 
// и выводит его элементы с двумя знаками после запятой через табуляцию.




double[] GenerateArray(int length, int minValue, int maxValue)
{
    double[] numbersMassive = new double[length];
    Random random = new Random();
    for (int i = 0; i < numbersMassive.Length; i++)
    {
        numbersMassive[i] = random.Next(minValue, maxValue + 1) + random.NextDouble();
    }
    return numbersMassive;

}

void PrintArray(double[] array)
{
    System.Console.Write($"{array[0]:f2}");
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($"\t{array[i]:f2}");
    }
    System.Console.WriteLine();
}

double FindMax(double[] array)
{
    double maxNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
    }
    return maxNumber;
}

double FindMin(double[] array)
{
    double minNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
    }
    return minNumber;
}

double CalcDifferenceBetweenMaxMin(double[] array)
{
    double difBetweenMaxMin = FindMax(array) - FindMin(array);
    return difBetweenMaxMin;
}

double[] myArray = GenerateArray(4, 1, 9);
double[] testArray = {3.17, 8.94, 2.36, 5.72, 0.85};

PrintArray(myArray);
System.Console.WriteLine($"Максимальное {FindMax(myArray):f2} и минимальное {FindMin(myArray):f2}");
double diff = CalcDifferenceBetweenMaxMin(myArray);
Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");

PrintArray(testArray);
System.Console.WriteLine($"Максимальное {FindMax(testArray):f2} и минимальное {FindMin(testArray):f2}");
diff = CalcDifferenceBetweenMaxMin(testArray);
Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");

