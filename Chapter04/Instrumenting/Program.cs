using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write to a text file in the project folder.
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));

            // Text writer is buffered, so this options calls
            // Flush() on all listeners after writing.
            Trace.AutoFlush = true;
            
            Debug.WriteLine("Debug says, I am watching!");
            Trace.WriteLine("Trace says, I am watching!");
            
            // Creating configuration builder that looks for
            // configuration JSON file.
            var builer = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            
            // Building the configuration.
            IConfigurationRoot configuration = builer.Build();
            
            //Creating trace switch.
            var traceSwitch = new TraceSwitch(
                displayName: "PacktSwitch",
                description: "This switch is set via JSON config.");
            
            // Setting switch level by binding to configuration.
            configuration.GetSection("PackSwitch").Bind(traceSwitch);
            
            Trace.WriteLine(traceSwitch.TraceError, "Trace error");
            Trace.WriteLine(traceSwitch.TraceWarning, "Trace warning");
            Trace.WriteLine(traceSwitch.TraceInfo, "Trace information");
            Trace.WriteLine(traceSwitch.TraceVerbose, "Trace verbose");
        }
    }
}
