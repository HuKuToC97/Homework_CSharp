double[] FindAverageInColumns(int[,] matrix)
{
    double[] results = new double [matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            results[i] +=matrix[j, i];
            
        }
        results[i]/=matrix.GetLength(0);
    }
    return results;
}

void PrintListAvr (double[] results)
{
    System.Console.WriteLine("The averages in columns are:");
    for (int i = 0; i < results.Length; i++)
    {
        System.Console.Write($"{results[i]:F2}\t");
    }
}

void PrintCheckIfError(int[] result, int x, int y)
{
    if (result[0] == 0)
    {
        System.Console.WriteLine("There is no such index");
    }
    else
    {
        System.Console.WriteLine($"The number in [{x}, {y}] is {result[0]}");
    }
}

int[,] GenerateArray(int m, int n, int k)
{
    int count = 0;
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 1 + k * count;
            count++;
        }
    }
    return array;
}

void printArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int m = 0; m < matrix.GetLength(1); m++)
        {
            Console.Write($"{matrix[i, m]}\t");
        }
    }
    Console.WriteLine();
}

int[,] userArray = GenerateArray(3, 4, 2);
printArray(userArray);

PrintListAvr(FindAverageInColumns(userArray));