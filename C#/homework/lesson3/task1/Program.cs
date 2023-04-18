// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

int num;

while (true)
{
    Console.Write("Введите пятизначное число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number) && (number / 10000 < 10 && number / 10000 >= 1))
    {
        num = number;    
        break;    
    }
    
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}

string result = num.ToString();

if (result[0] == result[4] && result[1] == result[3])
    {
        Console.WriteLine($"{result} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{result} - Не палиндром");
    }


