/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.*/

int[] ReadArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Введите элементы массива");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент #" + Convert.ToInt32(i + 1) + " = ");
        if (!int.TryParse(Console.ReadLine(), out array[i]))
        {
            i--;
            Console.WriteLine("Некорректный ввод");
        }
    }
    return array;

}
int[] Route(string variable)
{
    int size = 0;
    if (variable.ToUpper() == "N")
    {
        while (true)
        {
            Console.WriteLine("Введите размерность массива");
            if (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Некорректный ввод");
            }
            else break;
        }
        return ReadArray(size);
    }
    else if (int.TryParse(variable, out size))
    {
        return GetRandomArray(Convert.ToInt32(variable));
    }
    else
    {
        Console.WriteLine("Некорректный ввод");
        Console.WriteLine("Стандартное решение:");
        return GetRandomArray(8);
    }
}
string ReadNumber()
{
    string numberStr = string.Empty;
    int numberInt = 0;
    while (true)
    {
        Console.WriteLine("Введите размерность массива(Ручной ввод - нажмите N");
        numberStr = Console.ReadLine();
        if (!(int.TryParse(numberStr, out numberInt)) && (numberInt < 0) && (numberStr.ToUpper() != "N"))
        {
            Console.WriteLine("Некорректный ввод");
        }
        else break;
    }
    return numberStr;
}
int[] GetRandomArray(int size)
{
    Random random = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 1000);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length - 1] + "]");
}

Console.Clear();
PrintArray(Route(ReadNumber()));