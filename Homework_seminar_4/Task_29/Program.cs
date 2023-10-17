
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int ReadInt(string message)
{
    System.Console.Write(message + "  ");
    string value = Console.ReadLine();
    System.Console.WriteLine();
    return int.Parse(value);
}

int[] CreateMassine(int length)
{
    int maxNumberInMassive = ReadInt("Какое число будет максимальным в массиве? Введите чило: ");
        System.Console.WriteLine();
    int[] massive = new int[length];
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(maxNumberInMassive);
    }
    return massive;
}

void PrintMassive(int[] massive)
{
    System.Console.Write("Ваш массив:   ");
    foreach (var item in massive)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine();
}



System.Console.WriteLine("Программа создания массива");
int sizeNewMassive = ReadInt("Какой размер массива создать? Введите чило: ");
int[] massive = CreateMassine(sizeNewMassive);
PrintMassive(massive);
