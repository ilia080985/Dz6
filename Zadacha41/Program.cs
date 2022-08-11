// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.WriteLine("Числа больше нуля");
int[] numbers = CreateArray();
int count = 0;
foreach (int number in numbers)
if (number > 0) count++;
ShowResult(numbers, count);
int[] CreateArray()
{
Console.WriteLine("Введите числа массива через пробел:");
string[] userAnswer = Console.ReadLine().Split(" ");
int[] numbers = new int[userAnswer.Length];
try
{
for (int i = 0; i < userAnswer.Length; i++)
numbers[i] = Convert.ToInt32(userAnswer[i]);
}
catch
{
Console.WriteLine("Некорректный ввод");
return null;
}
return numbers;
}
static void ShowResult(int[] array, int result)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]}");
if (i != array.Length - 1)
Console.Write(", ");
}
Console.WriteLine($"] -> {result}");
}