// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
void EndProgram()
{
System.Console.WriteLine("Для выхода из программы нажмите любую клавишу");
System.Console.ReadKey();
System.Console.Clear();
}


string SaveNumbersReceivedFromTheUser(string msg)
{
    System.Console.Clear();
    string userNumbers = " ";
    char stopReading = '#';
    string heading = $"Для того чтобы остановить ввод чисел ввидите символ {stopReading}";
    System.Console.WriteLine(heading);
    System.Console.Write(msg);
    while (userNumbers[userNumbers.Length - 1] != stopReading)
    {
        userNumbers = userNumbers + System.Console.ReadLine();
        System.Console.Clear();
        System.Console.WriteLine(heading);
        System.Console.Write(msg);
        for (int i = 0; i < userNumbers.Length; i++)
        {
            System.Console.Write(userNumbers[i]+"|");
        }

    }
    System.Console.Clear();
    return userNumbers.Remove(userNumbers.Length - 1);
}

string userNumbers = SaveNumbersReceivedFromTheUser("Введите ваши числа: ");
System.Console.WriteLine($"Ваш массив:{userNumbers}");

EndProgram();

// void PrintUserNubers(string userNumbers)
// {

//     for (int i = 0; i < userNumbers.Length; i++)
//     {
//         if (userNumbers[i] != ',')
//         {
//             System.Console.Write(userNumbers[i]);
//         }
//         else
//         {
//             System.Console.Write(" ");
//         }
//     }

// }
// string userNumbers = "1,4,-5,15,25";
// PrintUserNubers(userNumbers);