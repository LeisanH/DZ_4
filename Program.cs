/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int a, b;
Console.Write($"Введите число А: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите число B: ");
int.TryParse(Console.ReadLine()!, out b);

if (b == 0)
    Console.Write(1);
else
{
    int ans = 1;
    for (int i = 0; i < b; i++)
        ans *= a;
    Console.Write(ans);
}