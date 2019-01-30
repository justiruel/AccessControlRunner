using System;

namespace AccessControlRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string strCmdText;
            strCmdText = "/C dotnet VDI.Demo.Web.Host.dll";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
    }
}
