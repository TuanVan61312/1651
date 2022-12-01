// using System;

// // try
// // {
// //     System.Console.WriteLine("Enter a: ");
// //     int a = int.Parse(Console.ReadLine());
// //     System.Console.WriteLine("Enter b: ");
// //     int b = int.Parse(Console.ReadLine());
// //     int c = a/b;
// // }
// // catch(FormatException)
// // {
// //     System.Console.WriteLine("invalid input");
// // }
// // catch(DivideByZeroException)
// // {
// //     System.Console.WriteLine("devide by zero");
// // }

// Console.Write("Enter length of array: ");
// int n = int.Parse(Console.ReadLine());

// int[] a = new int[n];
// sum = 0;
// for(int i = 0; i <= n; i++)
// {
//     Console.Write("Enter a[0]: ", i);
//     a[i] = int.Parse(Console.ReadLine());
//     sum += a[i];
// }

// Console.Write("Enter lower: ");
// int lower = int.Parse(Console.ReadLine());
// Console.Write("Enter upper: ");
// int upper = int.Parse(Console.ReadLine());
// int partialsum = 0;
// for(int i = lower; i < upper; i++)
// {
//     partiasum += a[i];
// }
// double rate = partialsum / sum;
// System.Console.WriteLine("Rate: " + rate);