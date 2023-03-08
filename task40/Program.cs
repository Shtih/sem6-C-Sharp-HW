// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник сo сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.WriteLine("Введите размер стороны А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер стороны B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер стороны C: ");
int C = Convert.ToInt32(Console.ReadLine());

if(A < B + C && B < A + C && C < B + A)
{
    Console.WriteLine("Треугольник существует");
}
else Console.WriteLine("Треугольник не существует");