#r "../src/StartProcess/bin/Debug/netstandard2.0/StartProcess.dll"

using PS = StartProcess.Processor;

PS.StartProcess("dotnet --info");