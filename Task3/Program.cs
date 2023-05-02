// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите значение N=");
int N = Convert.ToInt32(Console.ReadLine());
for (int A = 1; A <= N; A++)
{
    if (A == N)
    {
        double C = Math.Pow(A, 3); //Возведение в третью степень.
        Console.WriteLine($"{C} ");
        return;
    }

    double B = Math.Pow(A, 3); //Возведение в третью степень.
    Console.Write($"{B}, ");

}
