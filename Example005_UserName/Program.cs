﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "Маша")
{
    Console.WriteLine("Ура, это же Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}