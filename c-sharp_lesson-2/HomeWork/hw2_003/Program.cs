// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


int numberLength(int number)
{
    int lastindex = 0;
    while(number > 0)
    {
        number = number / 10;
        lastindex++;
    }
    return lastindex;
}

int[] arrayOfDigits(int number, int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        int digit = number % 10;
        array[i] = digit;
        number = number / 10;
    }
    return array;
}

int myNumber = Prompt("Введите число: ");
int index = numberLength(myNumber);
int[] array = arrayOfDigits(myNumber, index);

if (numberLength(myNumber) < 3)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    Console.WriteLine($"Третья цифра {myNumber} равна {array[2]}");
}