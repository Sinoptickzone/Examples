int[] array = { 1, 21, 32, 23, 43, 12, 23, 32 };
int n = array.Length;

int find = 23;
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