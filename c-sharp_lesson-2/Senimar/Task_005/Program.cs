// Напишите программу, которая выводит случайное число из отрезка [10, 9999]
// и показывает наибольшую цифру числа

int number = new Random().Next(10, 10000);
Console.WriteLine(number);
int max = -1;

while (number > 0)
{
    int digit = number % 10;
    if (max < digit)
    {
        max = digit;
    }
    number = number / 10;
}

Console.WriteLine(max);