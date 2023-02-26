// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();
Console.WriteLine("Задача 29");
int[] a = new int[8];
System.Random random = new System.Random();
bool isFirst = true;
for (int i=0; i<8; i++) {
    a[i] = random.Next(1, 100);
    string prefix = isFirst ? "" : ", ";
    if (isFirst) { isFirst = false; }
    Console.Write($"{prefix}{a[i]}");
}
Console.WriteLine(" -> [{0}]", string.Join(", ", a));
