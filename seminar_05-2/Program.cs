// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


Console.Clear();

Console.WriteLine($"Задача 35. 123 случайных числа. Диапазон от -1000 до 1000");

int[] numbers = new int[123];
FillArray(numbers, -1000, 1000);

void FillArray(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int count = 0;
for(int i = 0; i<numbers.Length; i++ )
{
  if (numbers[i]>=10 && numbers[i]<100)
    {
      count += 1;
    }
}
Console.WriteLine($"Число элементов от 10 до 99: {count} \n");



  // Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.WriteLine($"Задача 37");

int[] numbers1 = new int[6];

int IsEven(int[] numbers1){
  int middle = numbers1.Length / 2;
  if (middle % 2 != 1){
    middle = middle + 1;
  }
  return middle;
}

int middle = IsEven(numbers1);

int[] multiplication = new int[middle];
FillArray(numbers1, 1, 10);

for(int i = 0; i < middle; i++ )
{
  multiplication[i] = numbers1[i] * numbers1[numbers1.Length-i-1];

}

if ((numbers1.Length / 2) % 2 != 1){
  multiplication[middle-1] = numbers1[middle-1];
}

WriteArray(numbers1);
WriteArray(multiplication);