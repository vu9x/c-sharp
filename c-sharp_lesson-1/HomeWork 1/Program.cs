//Функция, на вход получает параметр, на выходе введенное с консоли значение
int Prompt(string message)
{
    System.Console.Write(message); // Выводит сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // возвращает результат
}

// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
System.Console.WriteLine("Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");

int a = Prompt("a =");
int b = Prompt("b =");
if (a == b)
{
    System.Console.WriteLine("Числа равны");
}
else if (a > b)
{
    System.Console.WriteLine($"max = a ({a}), min = b ({b})");
}
else
{
    System.Console.WriteLine($"max = b ({b}), min = a ({a})");
}

// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
System.Console.WriteLine("Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");

int first = Prompt("first =");
int second = Prompt("second =");
int third = Prompt("thrid =");
List<int> list = new List<int>{first, second, third};
System.Console.WriteLine($"Max element = {list.Max()}");

// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
System.Console.WriteLine("Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)");

int evenOrNot = Prompt("Введите число: ");
if(evenOrNot % 2 == 0)
{
    System.Console.WriteLine($"Число {evenOrNot} четное");
}
else
{
    System.Console.WriteLine($"Число {evenOrNot} нечетное");
}

// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
System.Console.WriteLine("Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

int allEvenNumbers = Prompt("Введите число: ");
System.Console.WriteLine($"Четные числа от 1 до {allEvenNumbers}");
for (int i = 1; i < allEvenNumbers; i++)
{
    if(i % 2 == 0 )
    {
        System.Console.WriteLine(i);
    }
}
