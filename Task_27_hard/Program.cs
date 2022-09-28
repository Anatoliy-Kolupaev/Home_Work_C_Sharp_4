// Задача № 27*
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Пример: 452 -> 11; 82 -> 10; 9012 -> 12
// * Сделать оценку времени алгоритма через вещественные числа и строки

int ReadData(string msg) 
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int Method1(int user_number)
{
    int result = 0;
    while ( user_number > 0)
    {
        result = result + user_number % 10;
        user_number = user_number / 10!;
    }
    return result;
}
int Method2(int  user)
{
    int sum = 0;
    for (int i = 0; i < user; i++)
    {
        sum = sum + user;
        System.Console.WriteLine(sum);
    }
    return sum;
}
void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}
int user_number = ReadData("Введите число: ");
int user = Convert.ToString(user_number).Length;
PrintData ("Сумму цифр в числе ", Method1(user_number));
PrintData ("Сумму цифр в числе ", Method2(user));

