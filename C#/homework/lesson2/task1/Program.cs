// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

int num;
int second_number;

while (true)
{
    Console.Write("Введите трехзначное число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number) && (number / 100 < 10 && number / 100 >= 1))
    {
            num = number;    
        break;    
    }
    
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}


second_number = (num / 10) % 10;

System.Console.WriteLine($"Вторая цифра трехзначного числа {num} - {second_number}");