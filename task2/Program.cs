/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/

int ReadNumber()
{
    int number = 0;
    while (true)
    {
        Console.WriteLine("Введите число ");
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Некорректный ввод");
        }
        else break;
    }
    return number;
}
int SumDigitInteger(int number)
{
    int sum = 0;
    while (Math.Abs(number) > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return Math.Abs(sum);
}
int SumDigitMethArray(int number)
{
    int sum = 0;
    int[] array = Math.Abs(number).ToString().Select(x => int.Parse(x.ToString())).ToArray();
    foreach (int i in array)
    {
        sum += i;
    }
    return sum;
}
Console.Clear();
int number = ReadNumber();
Console.WriteLine("Сумма(Метод математический)=" + SumDigitInteger(number));
Console.WriteLine("Сумма(Метод через массив)=" + SumDigitMethArray(number));