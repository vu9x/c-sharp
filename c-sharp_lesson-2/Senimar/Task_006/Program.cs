// Напишите программу, которая будет принимать на вход пять числе
// и выводить сумму и среднее арифметическое этих чисел.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

// int[] array = new int[5];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Prompt($"Введите {i}ый эелемент ");
// }

int[] inputarray(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i}ый эелемент ");
    }
    return array;
}


// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     sum = sum + array[i];
// }

int findSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}


int[] array = inputarray(3);
int newSum = findSum(array);

double average = newSum / ((double)array.Length);

Console.WriteLine($"Сумма = {newSum}, Средняя = {average}");
