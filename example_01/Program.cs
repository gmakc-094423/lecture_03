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

 Console.WriteLine(res);