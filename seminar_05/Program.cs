// сумма положительны . Сумма отрицательных
Console.Clear();
int[] numbers = new int[12];
FillArray(numbers);
WriteArray(numbers);
/* 
int sumPositive = 0;
int sumNegative = 0;
for(int i = 0; i<numbers.Length; i++ ){
  if (numbers[i]>0){
    sumPositive +=  numbers[i];
  }
  else sumNegative += numbers[i];
}
Console.WriteLine(sumPositive);
Console.WriteLine(sumNegative); */

void FillArray(int[] array){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(-9,10);
  }
}

void WriteArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

for(int i = 0; i<numbers.Length; i++ ){
  numbers[i] = numbers[i] * (-1);
  }
WriteArray(numbers);





// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// Console.Clear();
Console.WriteLine();
int[] numbers1 = new int[12]{-1, -8, -1, 5, 4, -8, -2, 5, 0, -1, 1, -7};

Console.Write("Введите проверяемое число: ");
int proverNumbers = Convert.ToInt32(Console.ReadLine());

int temp = 0;

for (int i=0; i< numbers.Length; i++)
{
  if(numbers1[i] == proverNumbers)
  {
    temp = 1;
    break;
  }
}

if (temp == 1)
{
  Console.WriteLine($"Проверяемое {proverNumbers} число есть!");
}
else Console.WriteLine($"Проверяемого  {proverNumbers} числа нет.");
