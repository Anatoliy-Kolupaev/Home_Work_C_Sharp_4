System.Console.WriteLine("Добрый день!");
int n = 0;
int v = 100;
while (n < v)
{
    Console.Write("Выберите задачу которую хотите проверить №: 25, 251, 27, 29, 291):  ");
    int choice = int.Parse(Console.ReadLine());
    while (choice == 25)
    {
        Console.WriteLine();
        Console.WriteLine("Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
        Console.WriteLine();
        if (choice == 25) Task25();
        if (choice == 25) Task25();
        if (choice == 25) Task25();
        break;

    }
    while (choice == 251)
    {
        Console.WriteLine();
        Console.WriteLine("Написать калькулятор с операциями +, -, /, * и возведение в степень.");
        Console.WriteLine();
        if (choice == 251) Task25_H();
        if (choice == 251) Task25_H();
        if (choice == 251) Task25_H();
        break;
    }
    while (choice == 27)
    {
        Console.WriteLine();
        Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр вчисле.");
        Console.WriteLine();
        if (choice == 27) Task27();
        if (choice == 27) Task27();
        if (choice == 27) Task27();
        break;
    }
     while (choice == 29)
    {
        Console.WriteLine();
        Console.WriteLine("Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
        Console.WriteLine();
        if (choice == 29) Task29();
        if (choice == 29) Task29();
        if (choice == 29) Task29();
        break;
    }
    while (choice == 291)
    {
        Console.WriteLine();
        Console.WriteLine("Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. *Ввести с клавиатуры длину массива и диапазон значений элементов");
        Console.WriteLine();
        if (choice == 291) Task29_H();
        if (choice == 291) Task29_H();
        if (choice == 291) Task29_H();
        break;
    }
    n++;
}

void Task25()
{
    int ReadData(string msg)
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    int Degree(int num, int num1)
    {
        int result = 1;
        for (int i = 1; i <= num1; i++)
        {
            result = result * num;
            // int result = Math.Pow(num, num1);
        }
        return result;
    }
    void PrintData(string msg, int value)
    {
        Console.WriteLine(msg + value);
    }
    int num = ReadData("Введите число А: ");
    int num1 = ReadData("Введите число B: ");
    int res = Degree(num, num1);
    PrintData("число A в степени B = ", res);
}

void Task25_H()
{
    int ReadDoIt(string msg)
    {
        Console.Write(msg);
        char number = char.Parse(Console.ReadLine());
        return number;
    }
    int ReadData(string msg)
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    int Summ(int num, int num1)
    {
        int sum = num + num1;
        return sum;
    }
    int Diff(int num, int num1)
    {
        int diff = num - num1;
        return diff;
    }
    int Division(int num, int num1)
    {
        int div = num / num1;
        return div;
    }
    int Multiplication(int num, int num1)
    {
        int mul = num * num1;
        return mul;
    }
    void PrintData(string msg, int value)
    {
        Console.WriteLine(msg + value);
    }
    int num = ReadData("Введите число А: ");
    int doit = ReadDoIt("Выберите действие '+' '-' '/' '*': ");
    int num1 = ReadData("Введите число B: ");
    if (doit == '+') PrintData("Результат = ", Summ(num, num1));
    if (doit == '-') PrintData("Результат = ", Diff(num, num1));
    if (doit == '/') PrintData("Результат = ", Division(num, num1));
    if (doit == '*') PrintData("Результат = ", Multiplication(num, num1));
}
void Task27()
{
    int ReadData(string msg)
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    int Method1(int user_number)
    {
        int result = 0;
        while (user_number > 0)
        {
            result = result + user_number % 10;
            user_number = user_number / 10;
        }
        return result;
    }
    void PrintData(string msg, int value)
    {
        Console.WriteLine(msg + value);
    }
    int user_number = ReadData("Введите число: ");
    PrintData("Сумму цифр в числе ", Method1(user_number));
}
void Task29()
{
    string ReadData(string msg)
    {
        System.Console.Write(msg);
        string number = (System.Console.ReadLine());
        number = number + " ";
        return number;
    }

    int[] ArrayOfNumbers(string array)
    {

        int[] arrayOfNumber = new int[1];

        int j = 0;

        for (int i = 0; i < array.Length; i++)
        {
            string series = "";

            while (array[i] != ' ' && i < array.Length)
            {
                series += array[i];
                i++;
            }
            arrayOfNumber[j] = Convert.ToInt32(series);
            if (i < array.Length - 1)
            {
                arrayOfNumber = arrayOfNumber.Concat(new int[] { 0 }).ToArray();
            }
            j++;
        }
        return arrayOfNumber;
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
    string arrLen = ReadData("Введите ряд чисел, разделенных пробелом: ");
    int[] arrayOfNumber = ArrayOfNumbers(arrLen);

    PrintArr(arrayOfNumber);
}
void Task29_H()
{
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
}