// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты первой точки через пробелы:");
string inputText1 = Console.ReadLine();
string[] strArray1 = inputText1.Split(" ");

Console.WriteLine("Введите координаты второй точки через пробелы:");
string inputText2 = Console.ReadLine();
string[] strArray2 = inputText2.Split(" ");
double sum = 0;
for(int i = 0; i < strArray1.Length; i++)
{
    double a=int.Parse(strArray1[i]);
    double b=int.Parse(strArray2[i]);
    double sq = Math.Pow((a-b), 2);
    sum = sum + sq;
}
double dist = Math.Sqrt(sum);
Console.Write("Расстояние между двумя точками равно "+dist);
