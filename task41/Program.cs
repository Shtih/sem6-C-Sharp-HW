//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] Array (int lenght)
{
int[] arr = new int [lenght]; 
    for(int i = 0; i < arr.Length; i++) // заполняем массив
    { 
        Console.Write("Введите элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
Console.WriteLine("Введите длину массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = Array(lenght);
Console.WriteLine($"Массив: [ {string.Join(", ", array)} ]");

int temp = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
        {
            temp = temp + 1;
        }
}
Console.WriteLine($"Количество положительных элементов в массиве: {temp}");


// for( int i = 0; i < array.Length; i++)
// {
//     int temp = 0;
//     if(array[i] >1)
//     {
//         Console.WriteLine(temp);
//         temp++;
//     }    
// }
