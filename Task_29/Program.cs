// Задача N 29* 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементо

int ReadData(string msg)
{
    System.Console.Write(msg);
    int number = int.Parse(System.Console.ReadLine() ?? "0");
    return number;
}

int[] FillArr(int len, int min, int max)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new System.Random().Next(min, max + 1);
    }
    return array;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

int arrLen = ReadData("Введите длину массива: ");
int min = ReadData("Введите нижню границу диапозона значений ");
int max = ReadData("Введите верхнюю границу диапозона значений ");
int[] arr = FillArr(arrLen, min, max);
PrintArr(arr);