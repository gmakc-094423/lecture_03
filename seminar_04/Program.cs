/* Console.Write("Введи число ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i<=number; i++){
  sum +=i;
}
Console.WriteLine("Ответ: "+sum); */


// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе


/* Console.Write("Введи число ");
int number = Convert.ToInt64(Console.ReadLine());

int quantity = 0;
int quantity1 = 0;
int number1 = number;

for (int i = 0; number > 0; i++){
  number /=10;
  quantity++;
}

while (number1 > 0){
  number1 /=10;
  quantity1++;
}

Console.WriteLine("Ответ: " + quantity);
Console.WriteLine("Ответ1: " + quantity1); */

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N

/* Console.Write("Введи число ");
int number = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= number; i++){
 //   quantity *=i;
// }
// int quantity = 1;
int Quantity(int number){
  int quantity = 1;
  int i = 1;
  while (i <= number){
    quantity *=i;
    i++;
  }
  return quantity;
}

int quantity = Quantity(number);

Console.WriteLine("Ответ: " + quantity); */


// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

// Console.Write("Введите число: ");
// int sqare = Convert.ToInt32(Console.ReadLine());

// void Sqare(int[] sqare){
//   int counter = 0;
//   int length = sqare.Length;
//   while (counter <  length){
//     sqare[counter] = Convert.ToInt32(Math.Pow(counter, 2));
//     counter++;
//   }
// }

// void PrintArry(int[] coll){
//   int count = coll.Length;
//   int index = 0;
//   while(index < count){
//     Console.Write(coll[index]+ " ");
//     index++;
//   }
// } 


// int[] arry = new int[sqare+1];
// Sqare(arry);
// PrintArry(arry);



// void FillIntArray (int[] array) {
//   int index = 0;
//   while (index < array.Length)
//   {
//     array[index] = new Random().Next(0, 2);
//     Console.Write(numbers[index] + ", ");
//     index++;
//   }
// }


/* int[] array = new int[8];

void ZeroOneArray(int[] array){
  for (int i=0; i < array.Length; i++){
    array[i] = new Random().Next(0, 2);
    Console.Write(array[i]+" ");
  }
}
ZeroOneArray(array); */

Console.WriteLine(123 % 10);