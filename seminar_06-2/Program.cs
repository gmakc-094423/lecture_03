// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


Console.Write("Введите N число Фибоначчи: ");
int numberNFib = Convert.ToInt32(Console.ReadLine());

int numberFib = 0;
int temorary1 = 1;
int temorary2 = 0;
for (int i = 0; i < numberNFib; i++)
{
  temorary2 = numberFib;
  numberFib = temorary2 + temorary1;
  temorary1 = numberFib- temorary2;
  // temorary2 = numberFib;
  Console.Write($"{numberFib}  ");
}

// Console.WriteLine($"\n{numberFib}");


// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
Console.Write($"\n");
int[] array = new int[6];

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

int[] CopyArray(int[] array){
  int[] copyArray = new int[array.Length];
  for (int i = 0; i < array.Length; i++)
  {
    copyArray[i] = array[array.Length - 1- i];
  }
  return copyArray;
}

FillArray(array);
WriteArray(array);
int[] copyArray = CopyArray(array);
WriteArray(copyArray);
