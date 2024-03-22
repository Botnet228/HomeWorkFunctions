int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
int count = 0;
void ListOutput()
{
    foreach (var e in arr)
    {
        Console.WriteLine(e);
    }
}

Console.WriteLine("🆕 Исходный список: ");
ListOutput();

for (int i = 0; i < arr.Length / 2; i++)
{
    count = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = count;
}

Console.WriteLine("✅ Перевернутый список: ");
ListOutput();