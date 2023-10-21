/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int enterInteger(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int sumFigureInNumber(int number)
{
    int count = number.ToString().Length;
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        sum += number%10;
        number /= 10;
        Console.WriteLine($"i : {sum}");
    }
    return sum;
}

int number = enterInteger("Введите число: ");
Console.WriteLine($"Сумма всех чисел равна: {sumFigureInNumber(number)}");
