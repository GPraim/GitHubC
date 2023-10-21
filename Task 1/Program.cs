/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int enterInteger(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double exponentiationNumberCycle(int a, int b)
{
    double result = a;
    for (int i = 1; i < b; i++)
    {
        result *= a;
    }
    return result;
}

double exponentiationNumber(int a, int b)
{
    double result = Math.Pow(a, b);
    return result;
}

int a = enterInteger("Введите число, которое будете возводить в степень: ");
int b = enterInteger("Введите число, которое будет являться степенью: ");
Console.WriteLine("Результат возведения в степень: " + exponentiationNumber(a, b));

Console.WriteLine("Результат возведения в степень c помощью цикла: " + exponentiationNumberCycle(a, b));