﻿Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a > 99 & a < 999) Console.Write("Вторая по счету цифра: {0}", (a/10)%10);
else Console.Write("Число не трехзначное");


