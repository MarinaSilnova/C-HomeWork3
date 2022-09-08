// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число ");
int n = Convert.ToInt32(Console.ReadLine());
if(Convert.ToString(n)[0] == Convert.ToString(n)[4] && Convert.ToString(n)[1] == Convert.ToString(n)[3])
    Console.WriteLine(" yes");
else
    Console.WriteLine(" no");

