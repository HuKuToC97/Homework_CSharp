// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
System.Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели ");
// int userNumber = int.Parse(Console.ReadLine());
string userNumber = Console.ReadLine();
switch (userNumber)
{
    case "1":
    case "2":
    case "3":
    case "4":
    case "5":
        System.Console.WriteLine("Этот будний день");
        break;
    case "6":
    case "7":
        System.Console.WriteLine("Этот день выходной");
        break;
    default:
        System.Console.WriteLine("Нет подходящего дня недели, попробуйте перезапустить программу и ввести цифру от 1 до 7");
        break;
}