using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace StartProcess {
    public class Processor {
        private static void StartProcess(string file, string args, string workingDir) {
            var info = new ProcessStartInfo {
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = workingDir
            };

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                info.FileName = file;
                info.Arguments = args;
                info.RedirectStandardError = true;
                info.RedirectStandardOutput = true;

                var process = Process.Start(info);

                process.OutputDataReceived += (s, e) => {
                    Console.WriteLine(e.Data);
                };
                process.ErrorDataReceived += (s, e) => {
                    Console.Error.WriteLine(e.Data);
                };

                process.BeginErrorReadLine();
                process.BeginOutputReadLine();

                process.WaitForExit();

            } else {
                info.FileName = file;
                info.Arguments = args;
                var process = Process.Start(info);
                process.WaitForExit();
            }
        }

        public static void StartProcess(string command, string workingDir = ".") {
            var dir = new System.IO.DirectoryInfo(workingDir).FullName;
            var args = command.Split(' ').Select(x => x.Trim());
            var process = args.Take(1).ElementAt(0);
            var processArgs = args.Skip(1).Aggregate((acc, n) => $"{acc} {n}");
            StartProcess(process, processArgs, dir);
        }
    }
}