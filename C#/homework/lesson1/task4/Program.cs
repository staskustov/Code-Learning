// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int i = 1;

int num;

Console.WriteLine("Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N");


while (true)
{
    Console.Write("Введите число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number)) {
    num = number;
    break;
    }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}

Console.WriteLine($"Чётные числа от 1 до {num}" );
while (i <= num) {
    if (i % 2 ==0) {
        Console.Write(i + ", ");
    }
    i++;

}






// Второе решение

// Console.WriteLine("Введите число N:");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Чётные числа от 1 до " + number);
// while (i <= number) {
//     if (i % 2 ==0) {
//         Console.Write(i + ", ");
//     }
//     i++;
// }

