// вид 1. Ничего не получают, ничего не возвращают
void Method1(){
  Console.WriteLine($"Первый метод");
}
// Method1();

// вид 2. Получают, но не ниччего не возвращают
void Method2(string message){
  Console.WriteLine($"Второй метод {message}");
}
// Method2("Это 2-й метод");

// вид 3. Возвращают, но не получают
int Method3(){
  return DateTime.Now.Year; 
}
int year = Method3();
// Console.WriteLine(year);

// вид 4. И возвращают и получают
string Method4(int count, string text){
  string result = String.Empty;
  int i = 0;
  while (i < count){
   result = result + text + " ";
    i++;
  }
  return result;
}
string res = Method4(text: "Это метод 4", count: 5);

//  Console.WriteLine(res);


/* for (int i=1; i<10;i++){
  Console.WriteLine($"\nУмножение на {i}");
  for (int j=1; j<10;j++){
    Console.Write($"{i}*{j}={i*j}; ");
  }
} */

/* string text = " Начальник войск радиационной, химической и биологической защиты"
+ " ВС РФ генерал-лейтенант Игорь Кириллов сообщил о трёх сценариях, которые "
+"США могут использовать для обвинения России в использовании оружия массового "+"уничтожения (ОМУ) на Украине. ";

string Replace(string text, char oldValue, char newValue){
  string result=String.Empty;
  int length = text.Length; 
  for (int i = 0; i < length; i++)
  {
    if (text[i]==oldValue) result =result + $"{newValue}";
    else result = result + $"{text[i]}";
  }
  return result;
}

string newText = Replace(text, ' ', '|');
Console.Write(newText);

newText = Replace(newText, 'к', 'К');
Console.Write(newText); */


int[] numbers = new int[20];

int[] FillIntArray (int[] array) {

  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(0, 1000);
    // Console.Write(numbers[i] + ", ");
  }
  return array;
}

int[] array = FillIntArray(numbers);

void PrintArray (int[] arr){
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine($"");
}

void SelectionSort(int[] array){
  for (int i = 0; i < array.Length-1; i++)
  {
    int minPosition = i;

    for (int j = i+1; j < array.Length; j++)
    {
      if (array[j] > array[minPosition]) minPosition = j;
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
  }

}

PrintArray(array);
SelectionSort(array);
PrintArray(array);



// int RandomNumber(int min, int max){   // функция получения рандомных чисел
//   return new Random().Next(min, max);
// }

// int number = RandomNumber(10, 100);
