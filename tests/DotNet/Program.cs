using System;
using PS = StartProcess.Processor;

namespace DotNet {
    class Program {
        static void Main(string[] args) {
            PS.StartProcess("dotnet --info");
        }
    }
}
