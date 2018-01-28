using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LC2ShortcutCOM;
using System.IO;

namespace LC2ShortCutCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            //this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //string[] args = Environment.GetCommandLineArgs();
            string text = "LetzteChance.Org";
            string source = @"C:\msvsmon120.bat";
            string path = @"C:\";
            try
            {
                //tbOut.Dock = DockStyle.Fill;

                if (args.Length >= 2)
                {
                    Console.WriteLine("Parameter gefunden:" + Environment.NewLine);
                    Console.WriteLine(args[0] + Environment.NewLine);
                    text = args[0];
                    Console.WriteLine(args[1] + Environment.NewLine);
                    source = args[1];
                    Console.WriteLine(args[2] + Environment.NewLine);
                    path = args[2];
                    Shortcut.Create(text, source, path);

                }
                else
                {
                    Console.WriteLine("Usage:" + Environment.NewLine);
                    Console.WriteLine("LC2ShortcutCLI <text> <source> <path>");
                    return;
                }
                //Console.Writeline("Please, press a key...");
                //Console.Read();
                Console.WriteLine(Environment.NewLine);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(path + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace, "Exception");

            }
        }
    }
}
