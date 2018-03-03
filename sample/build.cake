#r "../src/StartProcess/bin/Debug/net45/StartProcess.dll"

using StartProcess;

Processor.StartProcess("java -version");
Processor.StartProcess("wk-file-size ../README.md");