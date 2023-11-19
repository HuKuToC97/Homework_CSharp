
bool CheckEnteredNumbers(int min, int max, int k, int m)
{
    if (min >= 0 && max >= min && k > 0 && m > 0)
    {
        return true;
    }
    return false;
}

int[,] GenerateArray(int minLimitRandom, int maxLimitRandom, int k, int m)
{
    int[,] numbersArray = new int[k, m];
    Random random = new Random();
    for (int i = 0; i < numbersArray.GetLength(0); i++)
    {
        for (int j = 0; j < numbersArray.GetLength(1); j++)
        {
            numbersArray[i, j] = random.Next(minLimitRandom, maxLimitRandom + 1);
        }
    }
    return numbersArray;
}

void PrintArray(int[] matrix)
{
    for (int i = 0; i < matrix.Length - 1; i++)
    {

        Console.Write($"{matrix[i]}, ");

    }
    System.Console.Write($"{matrix[matrix.Length - 1]}");
    Console.WriteLine();
}

void PrintBigArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
    }
    Console.WriteLine();
}

int ReadConsoleToInt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int CountFindingNumbers(int[] array, int numberOfCount)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (numberOfCount == array[i])
        {
            count++;
        }
    }
    return count;
}

int[,] CreateArrayForCounterNumber(int[] array, int minLimitRandom, int maxLimitRandom)
{
    int[,] arrayCount = new int[2, maxLimitRandom - minLimitRandom + 1];
    int count = 0;
    for (int i = 0; count < arrayCount.GetLength(1); i++)
    {
        arrayCount[0, i] = minLimitRandom + count;
        count++;
    }
    for (int j = 0; j < arrayCount.GetLength(1); j++)
    {
        arrayCount[1, j] = CountFindingNumbers(array, minLimitRandom + j);
    }
    return arrayCount;
}

int[,] SortRowsDescending(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            for (int j = 0; j < matrix.GetLength(1) - k - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
        }

    }
    return matrix;
}

int SumOfRow(int[,] matrix, int row)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum += matrix[row, i];
    }
    return sum;
}

int[] MinimumSumRow(int[,] matrix)
{

    int tempIndexMinSum = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        if (SumOfRow(matrix, tempIndexMinSum) > SumOfRow(matrix, i))
        {
            tempIndexMinSum = i;
        }
    }
    int[] result = new int[2] { tempIndexMinSum + 1, SumOfRow(matrix, tempIndexMinSum) };
    return result;
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] resultMatrixMultiplication = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    int multiply;
    for (int n = 0; n < matrixA.GetLength(0); n++)
    {
        for (int m = 0; m < matrixB.GetLength(1); m++)
        {
            // System.Console.WriteLine();
            multiply = 0;
            // System.Console.WriteLine($"multiply={multiply}");
            for (int i = 0; i < matrixA.GetLength(1); i++)
            {
                multiply += matrixA[n, i] * matrixB[i, m];
                // System.Console.WriteLine($"[n] = {n}\t[i] = {i}\t[m] = {m}\nmatrixA[n,i] = {matrixA[n,i]}\tmatrixB[i,m] = {matrixB[i,m]}\nmultiply = {multiply}\n");
            }
            resultMatrixMultiplication[n, m] = multiply;
            // PrintBigArray(resultMatrixMultiplication);
        }
    }

    return resultMatrixMultiplication;
}

void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        // System.Console.WriteLine($"{matrixA.GetLength(1)} == {matrixB.GetLength(0)}");
        int[,] resultArray = MatrixMultiplication(matrixA, matrixB);
        PrintBigArray(resultArray);
    }
    else
    {
        System.Console.WriteLine("It is impossible to multiply.");
    }
}


System.Console.Clear();
System.Console.WriteLine("Программа позволяет составить частотный словарь элементов\nдля двумерного массива целых положительных чисел\n");
int minLimitRandom = ReadConsoleToInt("Введите минимальное целое положительное число для массива: ");
int maxLimitRandom = ReadConsoleToInt("Введите максимальное целое положительное число в массиве: ");
int lengthArray = ReadConsoleToInt("Введите кол-во строк в матрице: ");
int lengthArray2 = ReadConsoleToInt("Введите кол-во столбцов в матрице: ");

if (CheckEnteredNumbers(minLimitRandom, maxLimitRandom, lengthArray, lengthArray2))
{

    int[,] userArray = GenerateArray(minLimitRandom, maxLimitRandom, lengthArray+1, lengthArray2);
    int[,] autoArray = GenerateArray(minLimitRandom, maxLimitRandom, lengthArray2, lengthArray);
    PrintBigArray(userArray);
    System.Console.WriteLine();
    PrintBigArray(autoArray);
    MultiplyIfPossible(userArray, autoArray);

}
else
{
    System.Console.WriteLine("Введены не корректные значения!\nерезапустите программу и попробуйте еще раз.");
}