// Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран. 
// И ищет второй максимум (элемент меньше максимального, но больше всех остальных)
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19

int[] new_array()
{
    int[] array_8 = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array_8[i] = new Random().Next(1, 99);
    }
    return array_8;
}

int second_max(int[] array)
{
    int max = 0;
    int second_max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] > second_max && array[i] < max)
        {
            second_max = array[i];
        }
    }
    return second_max;
}

int[] numbers = new_array();
foreach (int i in numbers) { Console.Write($"{i}, "); }
Console.WriteLine($"Второй максимальный номер {second_max(numbers)}");