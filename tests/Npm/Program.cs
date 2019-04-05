using System;
using PS = StartProcess.Processor;

namespace Npm {
    class Program {
        static void Main(string[] args) {
            PS.StartProcess("npm.cmd --version");

            //var npm = @"""C:\Program Files\nodejs\npm.cmd""";
            //PS.StartProcess($"{npm} --version");
        }
    }
}
