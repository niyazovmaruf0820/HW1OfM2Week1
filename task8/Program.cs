int a = Convert.ToInt32(Console.ReadLine());
int s = 0;
int m = 0;
int sm = 0;
for (int i = a; i > 0; i /= 10)
{
    s += i % 10;
    m *= i % 10;
    sm = sm * 10 + i % 10;
}

for (int i = sm; i > 0; i /= 10)
{
    System.Console.Write((i % 10) + "+");
}