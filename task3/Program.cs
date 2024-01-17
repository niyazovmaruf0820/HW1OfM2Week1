int a;
int c = 0;
int s = 0;
for (int i = 0; ; i++)
{
    a = Convert.ToInt32(Console.ReadLine());
    s += a;
    if (a == 0) c++;
    else if (c == 1) c = 0;
    if (c > 1) break; 
}
System.Console.WriteLine(s);