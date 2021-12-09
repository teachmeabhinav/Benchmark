``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10.0.18363
Intel Core i5-10210U CPU 1.60GHz, 1 CPU, 8 logical cores and 4 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 2.1.28 (Framework 4.6.30015.01), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.1.28 (Framework 4.6.30015.01), 64bit RyuJIT


```
|               Method |     Mean |     Error |    StdDev |    Gen 0 |   Gen 1 |  Allocated |
|--------------------- |---------:|----------:|----------:|---------:|--------:|-----------:|
|    CalculateWithLinq | 6.181 ms | 0.1185 ms | 0.1050 ms | 242.1875 | 78.1250 | 1168.34 KB |
| CalculateWithNonLinq | 9.269 ms | 0.1416 ms | 0.1325 ms | 109.3750 | 31.2500 |  434.43 KB |
