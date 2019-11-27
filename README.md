# Most efficient way to reverse a string in c#

Here we have a few ways to reverse a string using a C# and checking the performance using BenchmarkDotNet

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


