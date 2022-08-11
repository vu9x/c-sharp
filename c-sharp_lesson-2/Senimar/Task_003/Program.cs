// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратное первому

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int num1 = Prompt("Введите первое число: ");
int num2 = Prompt("Введите второе число: ");
int ost = num1 % num2;

if(ost == 0)
{
    Console.WriteLine("Второе число является кратной первому");
} else {
    Console.WriteLine($"Не кратно, остаток {ost}");
}
