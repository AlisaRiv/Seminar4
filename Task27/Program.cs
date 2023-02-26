// Задача 27: Напишите программу, которая принимает на вход
//  число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.WriteLine("Задача 27");
Console.Write("Введите число: ");
string number = Console.ReadLine();
int i = 0;
int result = 0;
Console.Write($"{number} -> ");
while (i < number.Length) {
    result += int.Parse(Convert.ToString(number[i]));
    i++;
}
Console.WriteLine(result);

