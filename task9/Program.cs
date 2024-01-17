int a = Convert.ToInt32(Console.ReadLine());
for (int i = a; i > 0; i /= 10)
{
    System.Console.Write(i % 10);
}