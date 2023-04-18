// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

Console.WriteLine("Введите x1:");
int x1;
while(!int.TryParse(System.Console.ReadLine(), out x1)){System.Console.WriteLine("Это не число");}


Console.WriteLine("Введите y1:");
int y1;
while(!int.TryParse(System.Console.ReadLine(), out y1)){System.Console.WriteLine("Это не число");}


Console.WriteLine("Введите z1:");
int z1;
while(!int.TryParse(System.Console.ReadLine(), out  z1)){System.Console.WriteLine("Это не число");}


Console.WriteLine("Введите x2:");
int x2;
while(!int.TryParse(System.Console.ReadLine(), out x2)){System.Console.WriteLine("Это не число");}


Console.WriteLine("Введите y2:");
int y2;
while(!int.TryParse(System.Console.ReadLine(), out y2)){System.Console.WriteLine("Это не число");}


Console.WriteLine("Введите z2:");
int z2;
while(!int.TryParse(System.Console.ReadLine(), out z2)){System.Console.WriteLine("Это не число");}



int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2) + Math.Pow(C, 2));
Console.WriteLine($"Длинна отрезка {length}");