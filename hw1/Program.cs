using System;
using static System.Console;


Console.Clear();

string[] arr = AskArray();

string[] AskArray()
{
  Write("Введите значения через пробел: ");
  return ReadLine().Split(" ");
}

string[] GetValidArray(string[] array)
{
  int size = array.Length;
  int count = 0;
  for (int i = 0; i < size; i++)
  {
    if (array[i].Length <= 3)
    {
      count++;
    }
  }
  Console.WriteLine();


  string[] ValidArray = new string[count];
  {
    int j = 0;
    for (int i = 0; i < size; i++)
    {
      if (array[i].Length <= 3)
      {
        ValidArray[j++] = array[i];
      }
    }
    return ValidArray;
  }
}
string PrintArray(string[] array)
{
  int size = array.Length;
  string print = String.Empty;
  for (int i = 0; i < size; i++)
  {
    print += $"{array[i]} ";
  }
  return print;
}

Console.WriteLine();
Console.WriteLine(PrintArray(arr));
Console.WriteLine();
string[] valid = (GetValidArray(arr));

Console.WriteLine($"{PrintArray(valid)} ");
Console.WriteLine();
