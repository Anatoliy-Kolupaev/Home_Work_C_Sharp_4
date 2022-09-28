//Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

string ReadData(string msg)
{
    System.Console.Write(msg);
    string number = (System.Console.ReadLine());
    number = number + " ";
    return number;
}

int[] ArrayOfNumbers(string array){ 

  int[] arrayOfNumber = new int[1];    

  int j =0;

  for (int i = 0; i < array.Length; i++)
  {
    string series = "";

    while (array[i] != ' ' && i < array.Length)
    {
      series += array[i];
      i++;
    }
    arrayOfNumber[j] = Convert.ToInt32(series);    
    if (i < array.Length-1)
    {
      arrayOfNumber = arrayOfNumber.Concat(new int[] {0}).ToArray();    
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
int[] arrayOfNumber =  ArrayOfNumbers(arrLen);

PrintArr(arrayOfNumber);