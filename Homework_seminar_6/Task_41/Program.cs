// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}   ");
    }
    System.Console.WriteLine();
}

void EndProgram()
{
    System.Console.WriteLine("Для выхода из программы нажмите любую клавишу");
    System.Console.ReadKey();
    System.Console.Clear();
}


string SaveNumbersReceivedFromTheUser(string msg)
{
    System.Console.Clear();
    string userNumbers = "|";
    string bufferString = "";
    bool stopCheck = true;
    char stopReading = '#';
    string heading = $"Для того чтобы остановить ввод чисел ввидите символ {stopReading}\nЧтобы ввести следующее число нажмите клавишу Enter";
    System.Console.WriteLine(heading);
    System.Console.Write(msg);
    // while (userNumbers[userNumbers.Length-1] != stopReading)
    while (stopCheck != userNumbers.EndsWith("#|"))
    {
        bufferString = System.Console.ReadLine();
        userNumbers += bufferString + "|";
        System.Console.Clear();
        System.Console.WriteLine(heading);
        System.Console.Write(msg);
        for (int i = 0; i < userNumbers.Length; i++)
        {
            System.Console.Write(userNumbers[i]);
        }

    }
    System.Console.Clear();
    return userNumbers.Remove(userNumbers.Length - 2);
}

int[] ConvertUserStrigToArrayNumbers(string userStringNumbers)
{
    int[] userArrayNumbers = { 0 };
    int countRecords = 0;
    string dataBuffer = "";
    for (int i = 0; i < userStringNumbers.Length; i++)
    {
        if (userStringNumbers[i] != '|')
        {
            while (userStringNumbers[i] != '|')
            {
                dataBuffer += userStringNumbers[i];
                i++;
            }
            userArrayNumbers[countRecords] = Convert.ToInt32(dataBuffer);
            Array.Resize(ref userArrayNumbers, userArrayNumbers.Length + 1);
            dataBuffer = "";
            countRecords++;
        }
    }
    Array.Resize(ref userArrayNumbers, userArrayNumbers.Length - 1);
    return userArrayNumbers;
}

int NumberOfPositiveNumbersInTheArray(int[] userArray)
{
    int countPositiveNumbers = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i] > 0)
        {
            countPositiveNumbers++;
        }
    }
    return countPositiveNumbers;
}

string userNumbersInString = SaveNumbersReceivedFromTheUser("Введите ваши числа: ");
System.Console.WriteLine($"Ваш массив:{userNumbersInString}");
System.Console.WriteLine();
int[] userArray = ConvertUserStrigToArrayNumbers(userNumbersInString);
PrintArray(userArray);
System.Console.WriteLine($"Количество позитивных чисел в массиве равно: {NumberOfPositiveNumbersInTheArray(userArray)}");

EndProgram();