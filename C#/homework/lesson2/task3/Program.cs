// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

int num;

while (true)
{
    Console.Write("Введите цифру от 1 до 7: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number) && (number >=1) && (number <=7))
    {
        num = number;
        if(num <= 5) {
            Console.WriteLine($"{num} не является выходным");
        }
        else {
            Console.WriteLine($"{num} является выходным");
        }    
    break;    
    }
    
    Console.WriteLine("Не удалось распознать цифру.");
}

