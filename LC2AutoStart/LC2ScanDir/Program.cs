using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using letztechance.org.LC2System;

namespace LC2ScanDir
{
    class Program
    {
        static void Main(string[] args)
        {
            
            if (args.Length >= 1)
            {
             
                //LC2Sys.FullDirList(new DirectoryInfo("d:\\bin\\"), "*.dll");
                LC2Sys.FullDirList(new DirectoryInfo("" + args[0]), "" + args[1]);
                List<FileInfo> files = LC2Sys.getFiles();
                for (int i = 0; files.Count > i; i++)
                {
                    Console.WriteLine(files[i]);
                }
            }
            else
            {
                Console.WriteLine("LC2ScanDir v.1.0\n");
                Console.WriteLine("Usage:\nLC2ScanDir <path> <pattern>\n");
                Console.WriteLine("Exmple:\nLC2ScanDir c:\\ *.bat\n");
                Console.WriteLine("Press any key");
                Console.ReadKey();
            }
           
        }
    }
}
