using BenchmarkDotNet.Running;
using System;
using System.Runtime;

namespace ReverseString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Using server GC = { GCSettings.IsServerGC }");
            BenchmarkRunner.Run<Harness>();
        }
    }
}
