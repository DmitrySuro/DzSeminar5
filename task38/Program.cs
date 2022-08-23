/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным
элементов массива.
[3, 7, 22, 2, 78] -> 76
*/

System.Console.Clear();

double[] NewArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

double MinMaxNumberInArray (double[] array)
{
    int i = 0;
    double maxNumber = 0;
    double minNumber = array[i];
    while (i < array.Length)
    {
        if (maxNumber < array[i])
        {
            maxNumber = array[i];
        }
        if (minNumber > array[i])
        {
            minNumber = array[i];
        }
        i++;
    }
    System.Console.WriteLine($"Максимальное число в массиве = {maxNumber:f3}");
    System.Console.WriteLine($"Миниамальное число в массиве = {minNumber:f3}");
    double difference = maxNumber - minNumber;
    return difference;
}

System.Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine()!);
double[] array = new double[size];
array = NewArray(array);
System.Console.WriteLine("Вот массив");
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
System.Console.WriteLine($"Разница максимального и минимльного элемента массива = {MinMaxNumberInArray(array):f3}");