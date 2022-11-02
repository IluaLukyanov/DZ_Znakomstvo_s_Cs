Console.Write("Введите число для нахождения ряда кубов чисел до него начиная с 1: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[a];
int i;
Console.WriteLine("Четные числа до введенного числа:");
for (i=0; i<a; i++)
{
    mass[i] = (i+1)*(i+1)*(i+1);
    Console.WriteLine("{0} {1}", i+1, mass[i]);
}
