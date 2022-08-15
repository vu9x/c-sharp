// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N. 

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

double[] find_cube(int length)
{
    double[] array = new double[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = Math.Pow(i+1, 3);
    }
    return array;
}

int your_number = Prompt("Введите положительное число: ");
double[] cube_number = find_cube(your_number);

foreach(double i in cube_number)
{
    Console.Write($"{i}, ");
}