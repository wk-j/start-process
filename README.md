## Start Process

[![Build Status](https://dev.azure.com/wk-j/start-process/_apis/build/status/wk-j.start-process?branchName=master)](https://dev.azure.com/wk-j/start-process/_build/latest?definitionId=32&branchName=master)
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
