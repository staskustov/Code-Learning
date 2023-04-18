// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");


int num;

while (true)
{
    Console.Write("Введите число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
            num = number;    
        break;    
    }
    
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}


int[] PowArray(int number)
{
    int[] result = new int[number];
    for (int i = 0; i < number; i++)
    {
        result [i] = (int)Math.Pow(i + 1, 3);
    }
return result;
}

void PrintArray(int[] result)
{
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write($"{result [i]} ");
    }
}


PrintArray(PowArray(num));