// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");

int num_1;
int num_2;
int num_3;

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

while (true)
{
    Console.Write("Введите третье число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        // Console.WriteLine($"Вы ввели число {number}");
        num_3 = number;
        break;
    }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}

int max = num_1;

if (num_2 > max) {
    max = num_2;
}

if (num_3 > max) {
    max = num_3;
}

Console.WriteLine($"Наибольшее из введённых чисел: {max}");


// Второй вариант решения.

//Console.WriteLine("Введите 3 числа:");
//int num_1 = Convert.ToInt32(Console.ReadLine());
//int num_2 = Convert.ToInt32(Console.ReadLine());
//int num_3 = Convert.ToInt32(Console.ReadLine());

//int max = num_1;

//if (num_2 > max) {
//    max = num_2;
//}

//if (num_3 > max) {
//    max = num_3;
//}

//Console.WriteLine($"Наибольшее из введённых чисел: {max}");