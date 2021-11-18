``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10.0.18363
Intel Core i5-10210U CPU 1.60GHz, 1 CPU, 8 logical cores and 4 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 2.1.28 (Framework 4.6.30015.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.28 (Framework 4.6.30015.01), 64bit RyuJIT


```
|               Method |      Mean |     Error |    StdDev |
|--------------------- |----------:|----------:|----------:|
|    CalculateWithLinq |  9.655 ms | 0.3261 ms | 0.9461 ms |
| CalculateWithNonLinq | 16.675 ms | 0.7679 ms | 2.2643 ms |
