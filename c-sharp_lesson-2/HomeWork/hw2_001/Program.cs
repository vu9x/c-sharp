// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

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


int myNumber = Prompt("Введите трехначное число ");
int[] array1 = arrayOfDigits(myNumber);

Console.WriteLine($"Второе число {myNumber} равна {array1[1]}");
