using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace WinSearchDBAnalyzer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += ResolveAssembly;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static Assembly ResolveAssembly(object sender, ResolveEventArgs args)
        {
            Assembly thisAssembly = Assembly.GetExecutingAssembly();
            string name = args.Name.Substring(0, args.Name.IndexOf(',')) + ".dll";
            var files = thisAssembly.GetManifestResourceNames().Where(s => s.EndsWith(name));

            if (files.Any())
            {
                string fileName = files.First();

                using (Stream stream = thisAssembly.GetManifestResourceStream(fileName))
                {
                    if (stream != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        stream.CopyTo(ms);
                        byte[] data = ms.ToArray();
                        return Assembly.Load(data);
                    }
                }
            }
            return null;
        }
    }
}
