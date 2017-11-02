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

            if (args.Length == 0)
            {
                Form1 form = new Form1();
                form.ShowDialog();
                Environment.Exit(1);
            }

            Launcher launcher = new Launcher();
            launcher.breakArgs(args);
            launcher.launch();
        }
    }
}
