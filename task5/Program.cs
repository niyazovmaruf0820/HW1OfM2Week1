int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];

for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(arr);
int cnt = 0;
for (int i = 0; i < a - 1; i++)
{
    if (arr[i] == arr[i + 1])
    {
        System.Console.Write(arr[i] + " " + arr[i + 1] + " ");    
    }
}