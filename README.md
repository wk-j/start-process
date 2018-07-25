## Start Process

```bash
dotnet add package wk.StartProcess
```

## Usage

```csharp
using PS = StartProcess.Processor;

PS.StartProcess("java -version");
PS.StartProcess("wk-file-size ../README.md");
```