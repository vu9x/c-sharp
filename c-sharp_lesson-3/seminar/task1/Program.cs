// Напишите программу, которая принимает на вход координаты точки (X и Y), причем X и Y не равен 0
// и выдает номер четверти плоскости, в которой находится эта точка

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int x = Prompt("введите Х > 0 ");
int y = Prompt("введите Y > 0 ");

int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    return 4;

}

int quarter = GetQuarter(x, y);

if (x == 0 || y == 0)
    {
        System.Console.WriteLine("Не возможно вычислить номер четверти на Оси");
        return;
    }
System.Console.WriteLine($"Вы находитесь в {quarter} четверти");