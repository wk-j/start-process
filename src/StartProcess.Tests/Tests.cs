using System;
using Xunit;
using StartProcess;

namespace StartProcess.Tests {
    public class Tests {
        [Fact]
        public void Test1() {
            StartProcess.Processor.StartProcess("dotnet --info");
        }
    }
}