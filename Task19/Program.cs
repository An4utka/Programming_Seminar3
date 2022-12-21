// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// (читается слева направо и справа налево одинаково)

Console.Write("Enter a 5-digit number:");
string str = Console.ReadLine();

if (str[0] == str[4] && str[1] == str[3])

    Console.Write("Yes, it's a palindrome");

else
    Console.Write("Sorry, not a palindrome");
