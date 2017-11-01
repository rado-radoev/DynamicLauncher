using System;

namespace DynamicLauncher
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Launcher launcher = new Launcher();
            launcher.breakArgs(args);
            launcher.launch();
        }
    }
}
