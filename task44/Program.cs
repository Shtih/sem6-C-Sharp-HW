// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Fibo(int num)
{
    Console.Write("0 1 ");
    int neighb1 = 0;
    int neighb2 = 1;
    int res = 0;
    for(int A = 0; A < num - 2; A++)
    {
        res = neighb1 + neighb2;
        Console.Write($" {res} ");
        neighb1 = neighb2;
        neighb2 = res;
    }
}
Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Fibo(A);


// int[] arr = new int[A];
// arr[0] = 0;
// arr[1] = 1;

// // if(A == 1)
// // {
// //     Console.Write( (A - 1) );
// //     Console.Write($" {A} ");
// // }

// // while(A > 1)
// // {
// //     Console.WriteLine((A - 1) + (A-2));
// //     A = A - 1;
// // }

