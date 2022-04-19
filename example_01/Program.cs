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
string Method4(int count, string c){
  string result = String.Empty;
  int i = 0;
  while (i < count){
    Console.WriteLine(c);
    i++;
  }
  return result;
}
string res = Method4(5, "Это метод 4");
