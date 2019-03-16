using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace StartProcess {
    public class Processor {
        private static void StartProcess(string file, string args, string workingDir) {
            var info = new ProcessStartInfo {
                FileName = file,
                Arguments = args,
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = workingDir
            };

            var process = new Process {
                StartInfo = info
            };

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) { }

            process.Start();
            process.WaitForExit();
        }

        public static void StartProcess(string command, string workingDir = ".") {
            var args = command.Split(' ').Select(x => x.Trim());
            var process = args.Take(1).ElementAt(0);
            var processArgs = args.Skip(1).Aggregate((acc, n) => $"{acc} {n}");
            StartProcess(process, processArgs, workingDir);
        }
    }
}