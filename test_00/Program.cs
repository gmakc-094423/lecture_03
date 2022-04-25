//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Write("Введите числа через запятую: ");
string? _numbers = Console.ReadLine();
_numbers = _numbers?.Replace(" ", "");
string[]? _arrayNumbers = _numbers?.Split(new char[] {','});

long[] _arrayNumbers1 = new long[_arrayNumbers.Length];

for(int i = 0; i < _arrayNumbers?.Length; i++){
    _arrayNumbers1[i] = Convert.ToInt32(_arrayNumbers[i]);
    Console.Write($"{_arrayNumbers1[i]} ");
}
Console.WriteLine();
Console.Write(_arrayNumbers1?[1].GetType());
