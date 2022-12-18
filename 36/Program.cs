// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



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


int GetSumm(int[]array)
{
    int summ = 0;
    int j;
    for(j = 0; j<array.Length; j++)
    {
        if(j % 2 != 0)
        {
            summ += array[j];
        }
    }
    return summ;
}

int dimention = GetNumber("Введите длину массива: ");
int[] array = InitArray(dimention);
PrintArray(array);
int summ = GetSumm(array);
Console.WriteLine(summ);