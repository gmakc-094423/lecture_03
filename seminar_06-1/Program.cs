// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


Console.Write("Введите 1 число : ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число : ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 3 число : ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2 + number3 && number2 < number1 + number3 && number3 < number1 + number2)
{
  Console.WriteLine("Yes");
}
else Console.WriteLine("No");


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Write("Введите число : ");
int numberN = Convert.ToInt32(Console.ReadLine());

string Perevod(int temp)
{
    string bin = "";
    // int i=0;
    int temp1 = 0;
    while(temp > 0)
    {
      temp1 = temp % 2;
      temp = temp / 2;
      bin = bin + temp1;
      // Console.Write(temp1);

    }
    return bin;
} 
Console.WriteLine($"\n");

string bin = Perevod(numberN);

// tmp = 0;
for (int i = 0; i < bin.Length; i++)
{
  Console.Write($"{bin[i]} ");
}











/* int bin = Perevod(numberN);

for (int i = 0; i < bin.Length; i++)
{
  int temp = bin[i];
  bin[i] = bin[bin.Length - 1 - i];
  bin[bin.Length - 1 - i] = temp;
}
for (int i = 0; i < bin.Length; i++)
{
  Console.Write(bin[i]);
} */




/* int InputNumber(string chislo)
{
    Console.Write($"Введите число {chislo}  ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
 int a = InputNumber("A");
 string result = "" + a%2;
 
while (a>=2)
{
     a = a/2;
     int c = a%2;
    result = c + result;
}
Console.Write(result); */
/* 
Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ваше число - {number}");
string tempResult = string.Empty;
string result = string.Empty;

while (number != 0)
{
    tempResult += number % 2;
    number = number / 2;
}

for(int i = 0; i < tempResult.Length; i++)
{
    result += tempResult[tempResult.Length - 1 - i];
}

Console.WriteLine($"Число в двоичной системе - {result}");
 */

/* 
 int number = 8;//new Random().Next(0, int.MaxValue);

int binSize = 0;

int tempNumber = number;
while (tempNumber != 0)
{
    tempNumber /= 2;
    binSize++;
}

int[] binArray = new int[binSize];
tempNumber = number;
for (int i = binArray.Length - 1; i >= 0; i--)
{
    binArray[i] = tempNumber % 2;
    tempNumber /= 2;
}

Console.WriteLine($"number = {number}");
PrintArray(binArray);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}
 */