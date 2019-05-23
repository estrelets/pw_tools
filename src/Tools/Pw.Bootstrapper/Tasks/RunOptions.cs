using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Pw.Bootstrapper.Tasks
{
    public class RunOptions
    {
        public RunOptions(string fileName,
            string arguments = default,
            string directory = default,
            Dictionary<string, string> environmentVars = default,
            Action<ProcessStartInfo> configure = default,
            TextWriter output = default)
        {
            FileName = fileName;
            Arguments = arguments;
            Directory = directory;
            EnvironmentVars = environmentVars;
            Configure = configure;
            Output = output;
        }
        
        public string FileName { get; set; }
        public string Arguments { get; set; }
        public string Directory { get; set; }
        public Dictionary<string, string> EnvironmentVars { get; set; }
        public Action<ProcessStartInfo> Configure { get; set; }
        public TextWriter Output { get; set; }
    }
}