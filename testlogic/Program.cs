internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("bai 1");
        int n;
        n = int.Parse(Console.ReadLine());
        // int nGiaithua = TinhGiaiThua(n);
        // Console.WriteLine(nGiaithua);
        Console.WriteLine(TinhGiaiThua(n));
    }

    static int TinhGiaiThua(int n)
    {
        //cach 1: dung vong lap
        // int nResult = 1;
        // for (int i = n; i > 0; i--)
        // {
        //     nResult = nResult * i;
        // }
        // return nResult;

        //cach 2: dung de quy
        if(n == 0) return 1;
        return TinhGiaiThua(n - 1) * n;
    }
}