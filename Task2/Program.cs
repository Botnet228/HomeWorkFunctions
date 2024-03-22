Random rnd = new Random();
int SumEven = 0;
int[] arr = new int[100];

for (int i = 0; i < arr.Length; i++)
{
    int int_rnd = rnd.Next(100, 999);
    arr[i] = int_rnd;
    if (int_rnd % 2 == 0)
    {
        SumEven++;
    }
}

Console.WriteLine("Количество чётных чисел в массиве: " + $"{SumEven}");