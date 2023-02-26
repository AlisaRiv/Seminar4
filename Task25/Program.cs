// Задача 25: Напишите цикл, который принимает на вход два
//  числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.WriteLine("Задача 25");
Console.Write("Ведите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
double result = Math.Pow(a, b);
Console.Write($"{a}, {b} -> {result}");
