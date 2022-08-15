// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[] arrayOfDigits(int number)
{
    int[] array = new int[5];
    for (int i = 0; i < 5; i++)
    {
        int digit = number % 10;
        array[i] = digit;
        number = number / 10;
    }
    return array;
}



bool checking_number(int a)
{
    if (a < 9999 && a > 99999)
    {
        return false;
    }
    return true;
}

int number = Prompt("Введите 5ти значное числое ");
int[] number_array = arrayOfDigits(number);

if (checking_number(number) && number_array[0] == number_array[4]
&& number_array[1] == number_array[3])
{
    Console.WriteLine("Да");
}
else { Console.WriteLine("Нет"); }