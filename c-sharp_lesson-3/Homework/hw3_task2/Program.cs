// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

double[] Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    string[] str_array = readValue.Split(new[] { ',' });

    double[] double_array = new double[3];
    for (int i = 0; i < 3; i++)
    {
        double_array[i] = double.Parse(str_array[i]);
    }

    return double_array;
}

double find_distance(double[] A, double[] B)
{
    double distance = Math.Sqrt(Math.Pow(A[0] - B[0], 2) + Math.Pow(A[1] - B[1], 2) + Math.Pow(A[2] - B[2], 2));
    return distance;
}

double[] a = Prompt("Введите координаты A без пробелов, через запятую: ");
double[] b = Prompt("Введите координаты B без пробелов, через запятую: ");

double new_distance = find_distance(a, b);
Console.WriteLine($"Distance bewteen A and B is {new_distance}");
