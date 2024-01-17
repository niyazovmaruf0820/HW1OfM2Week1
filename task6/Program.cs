int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int c = arr[0];
for (int i = 1; i < a; i++)
{
    if (arr[i] < c) c = arr[i];
}
System.Console.WriteLine(c);