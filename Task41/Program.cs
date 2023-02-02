//Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.WriteLine("введите количество чисел в массиве M=  ");
int M = int.Parse(Console.ReadLine()!);
int[] array = new int[M];

int[] PrintArray(string[] args)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("введите элементы массива\t ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}
PrintArray(args);

Console.WriteLine();
Console.Write("введенный массив  ");
Console.WriteLine(String.Join(", ", array));
Console.WriteLine();

void GetArray(int[] array)
{
    int result = 0;
    foreach (int item in array)
    {
        if (item > 0) result++;
    }
    Console.WriteLine($"пользователь ввел {result} чисел больше нуля");
}
GetArray(array);

