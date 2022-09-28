// Задача №25
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// Пример: 3, 5 -> 243 (3⁵); 2, 4 -> 16

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
int num = ReadData ("Введите число А: ");
int num1 = ReadData ("Введите число B: ");
int res = Degree(num, num1);
PrintData ("число A в степени B = ", res);

