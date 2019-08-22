using System;

namespace Lnkexecutor.CoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            //   /C is mandatory to carry out the command specified by the arg string and then terminates
            startInfo.Arguments = $"/C {args[0]}";//put in the args line the name/path of the *.lnk to execute
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
