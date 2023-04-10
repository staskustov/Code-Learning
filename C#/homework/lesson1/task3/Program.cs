// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Программа, которая на вход принимает число и выдаёт является ли число чётным");

int num;

while (true)
{
    Console.Write("Введите число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        // Console.WriteLine($"Вы ввели число {number}");
        num = number;
        break;
    }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}

if (num % 2 == 1) {
     Console.WriteLine($"Число {num} является нечетным");
}
else {
     Console.WriteLine($"Число {num} является четным");
}






// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 1) {
//      Console.WriteLine($"Число {num} является нечетным");
// }
// else {
//      Console.WriteLine($"Число {num} является четным");
// }
