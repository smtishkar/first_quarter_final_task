Console.Clear();
int size = 3;
string[] array = FillArray(size);
PrintArray(array);
Console.WriteLine();

for (int i = 0; i < size; i++)
{
    if (array[i].Length <3)
        {
            Console.Write($"{array[i]} ");
        }
}

string[] FillArray(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число или слово: ");
        string value = Console.ReadLine();
        arr[i] = value;
    }
    return arr;
}

void PrintArray(string[] array)
{
    int count = size;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}