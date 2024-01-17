int a = Convert.ToInt32(Console.ReadLine());
int c = a;
while(a != 0)
{
    a = Convert.ToInt32(Console.ReadLine());
    if(a >= c && a != 0) c = a;
}
System.Console.WriteLine(c);