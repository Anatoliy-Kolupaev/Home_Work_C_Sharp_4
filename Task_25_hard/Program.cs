// Задача № 25*
// Написать калькулятор с операциями +, -, /, * и возведение в степень.

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
int Summ (int num, int num1)
{
    int sum = num + num1;
    return sum;
}
int Diff (int num, int num1)
{
    int diff = num - num1;
    return diff;
}
int Division (int num, int num1)
{
    int div = num / num1;
    return div;
}
int Multiplication (int num, int num1)
{
    int mul = num * num1;
    return mul;
}
void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}
int num = ReadData ("Введите число А: ");
int doit = ReadDoIt ("Выберите действие '+' '-' '/' '*': ");
int num1 = ReadData ("Введите число B: ");
if (doit == '+') PrintData ("Результат = ", Summ(num, num1));
if (doit == '-') PrintData ("Результат = ", Diff(num, num1));
if (doit == '/') PrintData ("Результат = ", Division(num, num1));
if (doit == '*') PrintData ("Результат = ", Multiplication(num, num1));
