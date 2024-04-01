using CSharp.Util.Logging;
using System;
using System.Windows.Forms;

namespace Main
{
    internal static class Program
    {
        public static Logger logger = Logger.GetLogger("logs", true, true, true);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {

            logger.Log(Level.INFO, "Loading " + typeof(Main));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
