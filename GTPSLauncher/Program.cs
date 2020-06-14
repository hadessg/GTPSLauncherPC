using System;
using System.IO;

namespace GTPSLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "GTPSLauncher by literally";
            Console.WriteLine("GTPSLauncher by literally1337");
            Console.WriteLine("Make sure to run as administartor before using!");
            Console.WriteLine("Please type the ip address of the server you wish to connect to. Please do not include the domain, Growtopia1.com,Growtopia2.com");
            String ipaddress = Console.ReadLine();
            Console.WriteLine("GTPS IP is: " + ipaddress + "?");
            String[] hostEntries = new String[2];
            String path = "C:\\Windows\\System32\\drivers\\etc\\hosts";
            hostEntries[0] = ipaddress + " growtopia1.com";
            hostEntries[1] = ipaddress + " growtopia2.com";
            for(int i = 0; i < 2; i++)
            {
                File.AppendAllText(path, hostEntries[i]+"\n");
            }
            Console.WriteLine("Hosts edited!Press any key to close. Not edited?Run as admin!");
            Console.ReadLine();
        }
    }
}

