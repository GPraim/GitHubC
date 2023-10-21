/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] generateArray(int size, int a, int b){
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(a, b);
    }
    return array;
}

void printMassive(int[] collection){
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
}

int[] array = generateArray(8, 1, 100);
Console.Write("Ваш массив: ");
printMassive(array);
