// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void EndProgram()
{
    System.Console.WriteLine("Для выхода из программы нажмите любую клавишу");
    System.Console.ReadKey();
    System.Console.Clear();
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}   ");
    }
    System.Console.WriteLine();
}


int[] CreateAStraightLineEquation(int equationNumbers)
{
    int[] equationСoefficients = new int[2];
    System.Console.WriteLine($"Для создания уранения №{equationNumbers + 1} вида y = kx + b  задайте его коэффициенты k и b:");
    System.Console.Write("Введите коэффициент k: ");
    equationСoefficients[0] = Convert.ToInt32(System.Console.ReadLine());
    System.Console.Write("Введите коэффициент b: ");
    equationСoefficients[1] = Convert.ToInt32(System.Console.ReadLine());

    return equationСoefficients;
}

int[][] CreateSomeQuantityAStraightLineEquations()
{
    System.Console.Clear();
    System.Console.Write("Введите количство уравнений: ");
    int quantityEquation = Convert.ToInt32(System.Console.ReadLine());


    int[][] equationsСoefficients = new int[quantityEquation][];

    for (int i = 0; i < quantityEquation; i++)
    {
        equationsСoefficients[i] = new int[2];
        equationsСoefficients[i] = CreateAStraightLineEquation(i);
    }
    for (int i = 0; i < equationsСoefficients.Length * 3; i++)
    {
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
    }
    for (int i = 0; i < equationsСoefficients.Length; i++)
    {
        System.Console.WriteLine($"Ваше уровнение №{i + 1}: y = {equationsСoefficients[i][0]}x + {equationsСoefficients[i][1]}");
    }
    return equationsСoefficients;
}

void PointofIntersectionOfStraightLines(int[][] tableOfEquation)
{
    int[] pointofIntersection = new int[2];
    pointofIntersection[1] = (tableOfEquation[1][1] - tableOfEquation[0][1]) / (tableOfEquation[0][0] - tableOfEquation[1][0]);
    pointofIntersection[0] = ((tableOfEquation[0][0] * pointofIntersection[1]) + tableOfEquation[0][1]);
    System.Console.WriteLine($"Точка пересечения прямых ваших уровнений ({pointofIntersection[0]};{pointofIntersection[1]})" );

}

int[][] tableOfEquation = CreateSomeQuantityAStraightLineEquations();
if (tableOfEquation.Length == 1)
{
    System.Console.WriteLine("У вас только одна прямая попробуйте еще раз");
}
else if (tableOfEquation.Length > 2)
{
    System.Console.WriteLine("У больше двух прямых, это сложная задача не под силу этой п рограмме");
}
else if (tableOfEquation.Length == 2)
{
    PointofIntersectionOfStraightLines(tableOfEquation);
}
System.Console.WriteLine();

EndProgram();


// int[][] arrayArrays= new int[2][];
// arrayArrays[0]= new int[]{1,2};
// arrayArrays[1]= new int[]{2,3};
// // int qwe = arrayArrays[2][1]-arrayArrays[1][1];
// System.Console.WriteLine(arrayArrays[0][1]);