## Start Process

[![NuGet](https://img.shields.io/nuget/v/wk.StartProcess.svg)](https://www.nuget.org/packages/wk.StartProcess)

```bash
dotnet add package wk.StartProcess
```

## Usage

```csharp
using PS = StartProcess.Processor;

PS.StartProcess("java -version");
PS.StartProcess("wk-file-size README.md");
```
