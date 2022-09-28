// Задача № 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Пример: 452 -> 11; 82 -> 10; 9012 -> 12

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
void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}
int user_number = ReadData("Введите число: ");
PrintData ("Сумму цифр в числе ", Method1(user_number));