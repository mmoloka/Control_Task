string[] CreateArray(int count)  // Создание исходного массива строк.
{
    return new string[count];
}

void FillArray(string[] array)  // Заполнение элементов исходного массива строк.
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива:");
        array[i] = Console.ReadLine();
    }
}

int FindLen(string[] array)      // Определение длины выходного массива строк.
{
    int len = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) len++;
    }
    return len;
}

string[] MainProblemSolution(string[] input, int len) // Главная задача получения выходного массива строк.
{
    string[] output = new string[len];
    int j = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}

string PrintArray(string[] arr)       // Метод печати массива строк.
{
    string result = String.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1) result += $"{arr[i]}, ";
        else result += $"{arr[i]}";
    }
    return result;
}

string[] inputArray = CreateArray(4);
FillArray(inputArray);
Console.WriteLine($"Исходный массив: [{PrintArray(inputArray)}]");
string[] outputArray = MainProblemSolution(inputArray, FindLen(inputArray));
Console.WriteLine($"Выходной массив: [{PrintArray(outputArray)}]");
