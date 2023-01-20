// Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
int [] randomArray(int length, int start, int end)
{   int[] result = new int[length];
    for(int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end+1);
    }
    return result;
}

int getUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void printArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
            Console.Write(", ");
        }
        else
        {
            Console.WriteLine("]");
        }
    }
}

int getCountOfEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
        {
            count += 1;
        }
    }
    return count;
}
int length = getUserData("Введите длину массива: ");
int[] array = randomArray(length, 100, 999);
printArray(array);
int count = getCountOfEvenNumbers(array);
if(count > 0)
{
    Console.WriteLine($"Количество четных чисел массива равна: {count}");
}
else
{
    Console.WriteLine($"Четных чисел нет");
}