// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//N = 5, получаем массив [1, 2, 5, 7, 19]
//N = 3, получаем массив [6, 1, 33]

Console.WriteLine("Введите число");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
int[] MakeArrayFill(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = Random.Shared.Next(1, 99);
    }
    return array;
}
void Print(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
MakeArrayFill(array);
Print(array);
