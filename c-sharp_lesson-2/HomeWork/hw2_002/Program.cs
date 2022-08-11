// Задача 2: Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.

int[] arrayOfDigits(int number)
{
    int[] array = new int[3];
    for (int i = 0; i < 3; i++)
    {
        int digit = number % 10;
        array[i] = digit;
        number = number / 10;
    }
    return array;
}

int deleteInTheMiddle (int[] array)
{
    return array[2] * 10 + array[0];
}

int randomNumber = new Random().Next(100, 1000);

int[] array = arrayOfDigits(randomNumber);
int newNumber = deleteInTheMiddle(array);
Console.WriteLine($"Рандомное число {randomNumber}, новое число {newNumber}");