

int ReadConsoleToInt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double[,] GenerateArray(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[j, i] = (random.Next(minLimitRandom * 100, maxLimitRandom * 100));
            array[j, i] /= 100;
        }
    }
    return array;
}

void printArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int m = 0; m < matrix.GetLength(1); m++)
        {
            Console.Write($"{matrix[i, m]:F2} \t");
        }
    }
    Console.WriteLine();
}

int m = ReadConsoleToInt("Введите количество строк массива: ");
int n = ReadConsoleToInt("Введите количество колоннок массива: ");

double[,] userArray = GenerateArray(m, n, -5, 9);
printArray(userArray);