// Задача 4: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int dayOfWeek = Prompt("Введите номер дня недели от 1 до 7: ");

if (dayOfWeek > 5)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Будни");
}