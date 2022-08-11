// Напишите программу. которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int number = Prompt("Введите число: ");
int ost7 = number % 7;
int ost23 = number % 23;
if(ost7 == 0 && ost23 == 0){
    Console.WriteLine("Кратно и 7, и 23");
}else {
    Console.WriteLine($"Не кратно 7 и 23. Остаток от 7 = {ost7}, остаток от 23 = {ost23}");
}

