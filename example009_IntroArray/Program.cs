int[] array = {1,42,35,42,5055,336,17,899};

int n = array.Length;
int find = 42;

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