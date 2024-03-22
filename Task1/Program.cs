
int SumEven = 0;

while (true)
{
    Console.WriteLine("Введите целое число :");
    string input = Console.ReadLine();
    if (input == "q")
    {
        Console.WriteLine("Завершил работу. Пользователь ввел q");
        break;
    }
    else
    {
        int int_input = Convert.ToInt32(input);
        SumEven = SumEven + int_input;
        if (SumEven % 2 == 0)
        {
            Console.WriteLine("Завершил работу. Сумма (" + $"{SumEven}" + ") введенных чисел чётная. ");
            break;
        }
        Console.WriteLine("Сумма всех введённых чисел: " + $"{SumEven}");
    }
    Console.WriteLine(" ");


}