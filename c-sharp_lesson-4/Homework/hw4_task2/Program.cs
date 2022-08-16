// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int[] Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int readValue_length = readValue.Length;
    int result = int.Parse(readValue);
    int[] array_number = new int[]{result, readValue_length};
    return array_number;
}

int[] arrayOfDigits(int number, int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        int digit = number % 10;
        array[i] = digit;
        number = number / 10;
    }
    return array;
}

int array_sum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

int[] your_number = Prompt("Введите ваше число: ");
int[] number_array = arrayOfDigits(your_number[0], your_number[1]);
int total_sum = array_sum(number_array);

Console.WriteLine($"Сумма цифр числа {your_number[0]} равно {total_sum}");