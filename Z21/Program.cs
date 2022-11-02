double[] massA = new double[3];
double[] massB = new double[3];
double[] AB = new double[3];
double rast = 0;
int i;
Console.WriteLine("Введите координаты A:");
for (i=0; i<3; i++) massA[i] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты B:");
for (i=0; i<3; i++) massB[i] = Convert.ToDouble(Console.ReadLine());
for (i=0; i<3; i++) 
{
    AB[i] = massA[i]-massB[i];
    rast += AB[i]*AB[i];
}
Console.WriteLine("Растояние между точками А и В равно {0}", Math.Sqrt(rast));