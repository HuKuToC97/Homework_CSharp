// Внутри класса Answer напишите метод DistanceBetweenPoints, 
// который принимает на вход координаты двух точек pointA и pointB 
// в виде массива целых чисел, и возвращает расстояние 
// между ними в 3D пространстве.

double Length(int[] pointA, int[] pointB)
{
    // Введите свое решение ниже
    double distance = 0;
    for (int i = 0; i < pointA.Length; i++)
    {
        distance += Math.Pow((pointA[i] - pointB[i]), 2);
    }
    distance = Math.Sqrt(distance);
    return distance;
}
int x1 = int.Parse(System.Console.ReadLine());
int x2 = int.Parse(System.Console.ReadLine());
int x3 = int.Parse(System.Console.ReadLine());
int y1 = int.Parse(System.Console.ReadLine());
int y2 = int.Parse(System.Console.ReadLine());
int y3 = int.Parse(System.Console.ReadLine());

double result = Length(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
Console.WriteLine($"{result:F2}");