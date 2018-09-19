#r "../src/StartProcess/bin/Debug/net45/StartProcess.dll"

using PS = StartProcess.Processor;

PS.StartProcess("java -version");
PS.StartProcess("ls -al", "..");
PS.StartProcess("wk-file-size ../README.md");