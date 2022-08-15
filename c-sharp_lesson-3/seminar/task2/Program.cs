// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y)


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int quarter = Prompt("Напишите номер четверти ");

string GetQuarter(int number)
{
    if (number == 1)
    {
        return "X > 0, Y > 0";
    }
    if (number == 2)
    {
        return "X < 0, Y > 0";
    }
    if (number == 3)
    {
        return "X < 0, Y < 0";
    }
    return "X > 0, Y < 0";

}

string current_place = GetQuarter(quarter);

System.Console.WriteLine($"Ваш диапазон данных находится в промежутке {current_place}");