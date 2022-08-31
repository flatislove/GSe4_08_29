/*Напишите цикл, который принимает на вход 2 числа(А и В) и возводит число А в натуральную степень В*/

int ReadNumber(string s)
{
    int number = 0;
    while (true)
    {
        Console.WriteLine("Введите число " + s);
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Некорректный ввод");
        }
        else break;
    }
    return number;
}
double Pow(int a, int b)
{
    double res = 1;
    for (int i = 1; i <= Math.Abs(b); i++)
    {
        res *= a;
    }
    if (b > 0)
    {
        return res;
    }
    else return 1 / res;
}

Console.Clear();
Console.WriteLine("A в степени В = " + Pow(ReadNumber("A"), ReadNumber("B")));



