// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");


int ThirdDigit(int number)
        {
            int result = -1;
            if (number >= 100)
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }

int num;
int digit;

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



digit = ThirdDigit(num);

if(digit < 0) {
    System.Console.WriteLine($"у числа {num} нет третьей цифры");
}

else {
    System.Console.WriteLine($"у числа {num} третья цифра {digit}");
}


