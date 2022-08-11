int[] array = { 11, 21, 31, 41, 41, 51, 61 };

int n = array.Length;
int find = 41;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
