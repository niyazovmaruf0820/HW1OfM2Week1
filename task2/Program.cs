int a = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double s = 0;
for (int i = 0; i <= n; i++)
{
    s += Math.Pow(a, i);
}
System.Console.WriteLine(s);