// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

double[] Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    string[] str_array = readValue.Split(new[] { ',' });

    double[] double_array = new double[2];
    for (int i = 0; i < 2; i++)
    {
        double_array[i] = double.Parse(str_array[i]);
    }

    return double_array;
}

double find_pow(double A, double B)
{
    double pow_number = Math.Pow(A, B);
    return pow_number;
}

double[] number = Prompt("Введите 2 цифры без пробелов, через запятую: ");
double new_number = find_pow(number[0], number[1]);
Console.WriteLine($"{number[0]} в степени {number[1]} равно {new_number}");