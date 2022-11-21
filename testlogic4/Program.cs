internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("bai 4");
        int sum = 0;
        int n,c,m;
        Console.Write("Nhap n: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Nhap c: ");
        c = int.Parse(Console.ReadLine());
        Console.Write("Nhap m: ");
        m = int.Parse(Console.ReadLine());
        Console.WriteLine("Tong so keo la: " + TongSoKeo(sum, n, c, m));
    }

    static int TongSoKeo(int sum, int n, int c, int m)
    {
        int i = 0;
        sum = n/c;
        
        if(sum > m)
        {
            i = 2;
        }else if(sum < m)
        {
            i = 0;
        }else
        {
            i = 1;
        }
        Console.WriteLine("So keo doi duoc la: " + i);
        return sum + i;
    }
}