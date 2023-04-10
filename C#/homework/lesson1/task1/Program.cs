
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

int num_1;
int num_2;


while (true)
{
    Console.Write("Введите первое число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        // Console.WriteLine($"Вы ввели число {number}");
        num_1 = number;
        break;
    }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}

while (true)
{
    Console.Write("Введите второе число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        // Console.WriteLine($"Вы ввели число {number}");
        num_2 = number;
        break;
    }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}

if(num_1 > num_2) {
    System.Console.WriteLine($"Больше {num_1}, меньше {num_2}");
}
else {
    System.Console.WriteLine($"Больше {num_2}, меньше {num_1}");
}

// Вариант 2

// Console.WriteLine("Введите два числа: ");
// int num_1 = Convert.ToInt32(Console.ReadLine());
// int num_2 = Convert.ToInt32(Console.ReadLine());
//if(num_1 == num_2) {
//System.Console.WriteLine("Числа равны");
//}
//else {
//    if(num_1 > num_2) {
//    System.Console.WriteLine($"Больше {num_1}, меньше {num_2}");
//}
//    else {
//    System.Console.WriteLine($"Больше {num_2}, меньше {num_1}");
//    }
// }



// Вариант 3

// System.Console.Write("Введите первое число: ");
// string first_number = System.Console.ReadLine();

// System.Console.Write("Введите второе число: ");
// string second_number = System.Console.ReadLine();

// int fn = int.Parse(first_number);
// int sn = int.Parse(second_number);

// if(fn == sn) {
// System.Console.WriteLine("Числа равны");
// }
// else {
//     if(fn > sn) {
//     System.Console.WriteLine($"Больше {fn}, меньше {sn}");
// }
//     else {
//     System.Console.WriteLine($"Больше {sn}, меньше {fn}");
//     }
// }

















