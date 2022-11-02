Console.Write("Введите число от 1 до 7 включительно: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a>=1 & a<=7)
{
        if (a<=5) Console.Write("Это рабочий день");
        else Console.Write("Это выходной");
}
else Console.Write("Написано же от 1 до 7");

