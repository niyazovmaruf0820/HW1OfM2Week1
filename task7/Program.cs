int a;
int s = 0;
int c = 0;
for (;;)
{
    System.Console.WriteLine("Give a number:");
    a = Convert.ToInt32(Console.ReadLine());
    s += a;
    c++;
    if (a == 0) 
    {
        c--;
        break;
    }
}
System.Console.WriteLine("Total sum of numbers: " + s);
System.Console.WriteLine("Total amount of numbers: " + c);