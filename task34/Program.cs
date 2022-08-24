//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

System.Console.Clear();

int[] NewArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

int CountEvenNumberInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0 )
        {
            count++;
        }
    }
    return count;
}


System.Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine()!);

int[] array = new int[size];
array = NewArray(array);

System.Console.WriteLine("[" + string.Join(", ", array) + "]");
System.Console.WriteLine(CountEvenNumberInArray(array));

