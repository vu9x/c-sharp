int randomNumber = new Random().Next(10, 99);
Console.WriteLine(randomNumber);

int maxDigit(int randomNumber)
{
    int a1 = randomNumber % 10;
    Console.WriteLine($"a1 = {a1}");
    int a2 = randomNumber / 10;
    Console.WriteLine($"a2 = {a2}");
    if (a1 > a2) { return a1; }
    else { return a2; };
}

Console.WriteLine(maxDigit(randomNumber));