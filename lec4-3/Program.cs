// рекурсия функция которая вызывает сама себя
// вычисление факториала
// 5! = 5 * 4 * 3 * 2 * 1
// 5! = 5 * 4!
//          4! = 4 * 3!
//                   3! = 3 * 2!
//                            2! = 2 * 1
// метод который принимает число и возвращает еего факториал

double factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * factorial(n - 1);
}

for(int i = 1; i < 40; i++)
{
Console.WriteLine($"{i}! = {factorial(i)}");
}

// double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

