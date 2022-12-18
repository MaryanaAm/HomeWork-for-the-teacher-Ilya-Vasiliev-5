//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    return result;
}

int[]InitArray(int dimention)
{
    int[] array = new int[dimention];
    Random rnd = new Random();
    for (int i = 0; i < dimention; i++)
    {
        array[i] = rnd.Next(10,50);
    }
    return array;
}

// вывод массива в консоль

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

(int, int) GetResult(int[]array)
{
    int count = 0;
    int evenNums = 0;

    for(int j = 0; j<array.Length; j++)
    {
        if(array[j] % 2 == 0)
            count++;
            evenNums += array[j];
    }
    return (count, evenNums);
}

int dimention = GetNumber("Введите длину массива: ");
int[] array = InitArray(dimention);
PrintArray(array);
(int count, int evenNums) = GetResult(array);
Console.WriteLine($"Количество четных чисел: {count} , сумма: {evenNums}");

