// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


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

int[] ReverseArray(int[] array)
{
int temp = 0;
for(int i = 0; i < array.Length / 2; i++)
{
temp = array[i];
array[i] = array[array.Length - 1 - i];
array[array.Length - 1 - i] = temp;
}
return array;
}


array = ReverseArray(array);
Console.WriteLine($"[ {string.Join(", ", array)} ]");
