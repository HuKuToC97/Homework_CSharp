// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ReadInt(string msg)
{
    System.Console.Write(msg);
    string userNumberForParse = Console.ReadLine();
    int userNumber;
    userNumber = int.Parse(userNumberForParse);
    return userNumber;
}


int userNumber = ReadInt("Введите число:");
int countNumber = userNumber;
int i = 0;
while (countNumber > 9)
{
    countNumber /= 10;
    i++;
    // System.Console.WriteLine($"Проход №{i} число {countNumber}");
}

if (i <= 1)
{
    System.Console.WriteLine($"{userNumber} -> третьей цифры нет");
}
else
{
    int helpCount = (int)Math.Pow(10, (i - 2));
    System.Console.WriteLine($"{userNumber} -> {userNumber / helpCount % 10}");
}



// Ниже остатки кода, решил их сохранить для себя.  
//В начале планировал через разворот числа, потом подумал,/
// что можно через массив, в итоге пришел к решению выше
// int ReversalNumber(int normalNumber)
// {
//     int reversalNumber = 0;
//     while (normalNumber > 0)
//     {
//         reversalNumber *= 10;
//         reversalNumber += normalNumber % 10;
//         normalNumber /= 10;
//     }
//     System.Console.WriteLine(reversalNumber);
//     return reversalNumber;
// }

// int reversalNumber = ReversalNumber(userNumber);



// if (userNumber > 99) 
// {
//     if (userNumber % 10 == 0)
//     {
//         System.Console.WriteLine();
//     }
//     else
//     {
//         System.Console.WriteLine(reversalNumber / 100 % 10);
//     }
// }
// else
// {
//     System.Console.WriteLine("третьей цифры нет");
// }







