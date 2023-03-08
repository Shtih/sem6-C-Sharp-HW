//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

int y = 0;
int y1 = 1;
int x = 0;
int x1 = 0;

y = k1 * x + b1;
x = (y - b1) / k1;
y = k1 * (y - b1) / k1 + b1;
x = (y - b1) / k1;
Console.WriteLine($"Координата х {x}, координата y {y}");

y1 = k2 * x + b2;
x1 = (y - b2) / k2;
y1 = k2 * (y - b2) / k2 + b2;
x1 = (y - b2) / k2;
Console.WriteLine($"Координата х1 {x1}, координата y {y1}");


