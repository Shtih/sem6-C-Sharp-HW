// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10



void BinaryView( int num)
{
    if(num <= 0)
    {
        return;
    }
    BinaryView(num / 2);
    Console.WriteLine(num % 2);

}

Console.WriteLine("Введите число: ");
int num  = Convert.ToInt32(Console.ReadLine());
BinaryView(num);
