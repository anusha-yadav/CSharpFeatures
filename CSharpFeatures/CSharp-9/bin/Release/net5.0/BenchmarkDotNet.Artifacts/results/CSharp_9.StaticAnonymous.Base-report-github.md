```

BenchmarkDotNet v0.13.11, Windows 10 (10.0.19045.3803/22H2/2022Update)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.402
  [Host]     : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2
  DefaultJob : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2


```
| Method                     | Mean     | Error     | StdDev    | Gen0   | Allocated |
|--------------------------- |---------:|----------:|----------:|-------:|----------:|
| MultiplyNonStatic          | 8.235 ns | 0.2000 ns | 0.4085 ns | 0.0153 |      64 B |
| MultiplyNonStaticWithConst | 2.824 ns | 0.0910 ns | 0.2198 ns |      - |         - |
| MultiplyStatic             | 2.200 ns | 0.0823 ns | 0.1397 ns |      - |         - |
