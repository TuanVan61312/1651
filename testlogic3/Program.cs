internal class Program
{
    private static void Main(string[] args)
    {
        int [] arr = {0, 7, 11, 8, 4};
        // int max_pos = 0;
        int size = arr.Length;
        Console.WriteLine("bài 3");
        PrintArr(arr, size);
        FindMax(arr, size);
        // Console.WriteLine(n);
        // DeleteMax(arr, max_pos,size);
        PrintArr(arr, size-1);
    }

    static void FindMax(int [] arr, int size)
    {
        int max = arr[0];
        int max_pos = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (max < arr[i])
            max = arr[i];
            max_pos = i;
        }
        // return max;

        for(int i = max_pos; i < size; i++)
        {
            arr[i] = arr[i + 1];
        }
        size--;
    }

    // static void DeleteMax(int[] arr, int max_pos, int size)
    // {
    //     for(int i = max_pos; i < size - 1; i++)
    //     {
    //         arr[i] = arr[i+ 1];
    //     }
    //     size--;
    // }

    static void PrintArr(int[] arr, int size)
    {
        for(int i = 0; i <size; i++)
        {
        Console.WriteLine(i + " = " + arr[i]);
        }
    }
}