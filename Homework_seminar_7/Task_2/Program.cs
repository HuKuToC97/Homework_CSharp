int[] FindNumbersInArray(int[,] matrix, int x, int y)
{
    int[] result = new int[2];
    if (matrix.GetLength(0) >= x && matrix.GetLength(1) >= y)
    {
        result[0] = matrix[x - 1, y - 1];
        return result;
    }
    else
    {
        return result;
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

int[,] userArray = GenerateArray(4, 5, 3);
printArray(userArray);
int x = 2;
int y = 2;


PrintCheckIfError(FindNumbersInArray(userArray, x, y), x, y);