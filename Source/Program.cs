using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSVMerger
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            
            if (args.Length > 0)
            {
                CSVMerger m = new CSVMerger(false);
                m.merge_Click(null, null);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new CSVMerger());
            }
        }
    }
}
