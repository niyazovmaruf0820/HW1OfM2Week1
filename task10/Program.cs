int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int cnt = 0;
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < int.MaxValue; j++)
    {
        if (arr[i] % j == 0) cnt++;
        if (cnt < 3)
        System.Console.Write(arr[i] + " ");
    }
}
