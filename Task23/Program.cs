// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Enter your number:");
int N=int.Parse(Console.ReadLine());
Console.Write(N + " -> ");
for (int i = 0; i<=N; i ++)
{
Console.Write(Math.Pow(i,3) + " ");
}