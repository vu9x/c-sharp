// Напишите программу, которая принимает на вход трехначное число и на выходе покаывает последнюю цифру этого числа
int FindLastNumber(int number)
{
    int result = number % 10;
    return result;
}

int myNumber = FindLastNumber(123);

Console.WriteLine(myNumber);