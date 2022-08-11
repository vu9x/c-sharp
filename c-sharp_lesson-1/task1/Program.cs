// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Напишите программу. которая на вход принимает число и
// выдает его квадрат (число умноженное на само себя).

//Функция, на вход получает параметр, на выходе введенное с консоли значение
int Prompt(string message)
{
    System.Console.Write(message); // Выводит сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // возвращает результат
}

int value = Prompt("Введите число > "); // вводим значение
int result = value * value; // Вычисляем квадрат
//System.Console.WriteLine($"Квадрат числа {value} равен {result}"); // Вывод результата

// Задача 1: Напишите программу, которая на вход принимает два числа и проверяет, является ли первое квадратом второго:
System.Console.WriteLine("Задача 2:Напишите программу, которая на вход принимает два числа и проверяет, является ли первое квадратом второго");
int controlValue = Prompt("Введите проверочное число: ");
if(result == controlValue)
{
    System.Console.WriteLine(true);
}
else
{
    System.Console.WriteLine(false);
}

// Задача 2: Напишите программу, которая на вход принимает два числа и проверяет, является ли первое квадратом второго:

System.Console.WriteLine("Задача 2:Напишите программу, которая на вход принимает два числа и проверяет, является ли первое квадратом второго");
