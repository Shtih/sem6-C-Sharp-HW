// Задача 45: Напишите программу, 
//которая будет создавать копию заданного массива 
//с помощью поэлементного копирования.

int[] RandomArray (int lenght)
{
int[] arr = new int [lenght]; // выделяем память под длину массива
    Random rnd = new Random(); //
    for(int i = 0; i < arr.Length; i++) // заполняем массив
    { // индекс от 0, пока не кончится длина массива, добавляя по еденице
        arr[i] = rnd.Next(-100, 101); // рандомные числа от - 9 до 9
    }
    return arr;
}
Console.WriteLine("Введите длину массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = RandomArray(lenght);
Console.WriteLine($"[ {string.Join(", ", array)} ]");

int[] MirrorArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = array[i];
}
return array;
}
array = MirrorArray(array);
Console.WriteLine($"[ {string.Join(", ", array)} ]");
