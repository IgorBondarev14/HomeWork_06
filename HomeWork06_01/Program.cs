// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.

Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 1; i <= M; i++)
{
    Console.Write("Введите число " + i + ": ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
        count++;
}
Console.WriteLine("Пользователь ввёл "+ count + " положительных чисел");
