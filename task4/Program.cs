/*Напишите программу, которая задаёт массив из 10 элементов, которые необходимо заполнить случайными значениями в диапазоне от -10 до 10 и найти максимальное значение среди них*/
int ReadNumber()
{
    int number = 0;
    while (true)
    {
        Console.WriteLine("Введите размерность массива");
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Некорректный ввод");
        }
        else break;
    }
    return number;
}

int[] GenerateRandomArray(int size)
{
    Random random = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 10);
    }
    return array;
}
int FindMaxElemArray(int[] array)
{
    return array.Max();
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

Console.Clear();
int[] array = GenerateRandomArray(ReadNumber());
PrintArray(array);
Console.WriteLine("Максимальное = " + FindMaxElemArray(array));