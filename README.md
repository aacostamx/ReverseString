# Most efficient way to reverse a string in c# using BenchmarkDotNet

Here we have a few ways to reverse a string using a C# and checking the performance using BenchmarkDotNet

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i7-6700HQ CPU 2.60GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100
  [Host] : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT  [AttachedDebugger]

Job=InProcess  Toolchain=InProcessEmitToolchain

|               Method |           text |      Mean |     Error |    StdDev |    Median |
|--------------------- |--------------- |----------:|----------:|----------:|----------:|
|           ReverseFor |        AACOSTA |  28.77 ns |  0.684 ns |  1.351 ns |  28.41 ns |
|           ReverseXor |        AACOSTA |  33.89 ns |  0.787 ns |  2.004 ns |  32.97 ns |
| ReverseStringBuilder |        AACOSTA |  57.45 ns |  0.704 ns |  0.624 ns |  57.33 ns |
|         ReverseWhile |        AACOSTA | 193.48 ns |  5.137 ns | 14.903 ns | 190.57 ns |
|          ReverseLINQ |        AACOSTA | 266.35 ns |  7.240 ns |  8.047 ns | 263.55 ns |
|     ReverseRecursive |        AACOSTA | 282.11 ns |  6.309 ns | 18.502 ns | 278.36 ns |
|           ReverseFor | aacosta.com.mx |  40.95 ns |  0.916 ns |  2.196 ns |  40.38 ns |
|           ReverseXor | aacosta.com.mx |  48.03 ns |  0.606 ns |  0.537 ns |  47.95 ns |
| ReverseStringBuilder | aacosta.com.mx |  88.53 ns |  1.896 ns |  3.959 ns |  86.93 ns |
|         ReverseWhile | aacosta.com.mx | 400.97 ns |  8.248 ns | 18.951 ns | 394.94 ns |
|          ReverseLINQ | aacosta.com.mx | 384.81 ns |  7.578 ns | 10.623 ns | 383.72 ns |
|     ReverseRecursive | aacosta.com.mx | 665.97 ns | 14.876 ns | 34.477 ns | 657.21 ns |

// * Warnings *
Environment
  Summary -> Benchmark was executed with attached debugger

// * Legends *
  text   : Value of the 'text' parameter
  Mean   : Arithmetic mean of all measurements
  Error  : Half of 99.9% confidence interval
  StdDev : Standard deviation of all measurements
  Median : Value separating the higher half of all measurements (50th percentile)
  1 ns   : 1 Nanosecond (0.000000001 sec)

// ***** BenchmarkRunner: End *****
// ** Remained 0 benchmark(s) to run **
