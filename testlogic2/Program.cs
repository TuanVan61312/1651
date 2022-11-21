internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("bai 2");
        int n = int.Parse(Console.ReadLine());
        if(check(n))
        {
            Console.WriteLine(n + " la so hoan hao");
        }else
        {
            Console.WriteLine(n + " khong la so hoan hao");
        }
    }

    static bool check(int n)
    {
        int sum = 0;
        for(int i = 1; i <= n/2; i++)
        {
            if(n%i == 0) sum += i;
        }
        if(sum==n)
        {
            return true;
        }
        return false;
    }
}