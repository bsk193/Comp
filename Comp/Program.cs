using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp
{
    static class Program
    {
        public static Students students = new Students();
        public static String[] lvStud = new String[Program.students.Count];
        public static String[] lvSubj = new String[Program.students.Count];
        public static Int32 lvIndex = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
