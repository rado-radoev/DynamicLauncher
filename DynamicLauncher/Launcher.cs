using System.Diagnostics;

namespace DynamicLauncher
{
    /// <summary>
    /// Class that will create a custom launcher depending on the provided settings
    /// </summary>
    /// 
    class Launcher
    {
        // External executable attributes
        private string executable;
        private string startPoint;
        private string arguments;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Launcher() { }

        /// <summary>
        /// Overloaded Constructor that will create a launcher object with the provided settings
        /// </summary>
        /// <param name="executable">Name of the executable</param>
        /// <param name="arguments">Arguments to pass to executable</param>
        /// <param name="startPoint">Executable working folder</param>
        public Launcher(string executable, string arguments, string startPoint)
        {
            Executable = executable;
            Arguments = arguments;
            StartPoint = startPoint;
        }

        // Getters and setters for the attributes
        public string Executable { get => executable; set => executable = value; }
        public string StartPoint { get => startPoint; set => startPoint = value; }
        public string Arguments { get => arguments; set => arguments = value; }

        /// <summary>
        /// Method to gather information from command line passed as a parameter and assign to appropriate variables
        /// </summary>
        /// <param name="args">Array of arguments</param>
        public void breakArgs (string[] args)
        {
            foreach (string item in args)
            {
                argumentHelper(item);
            }
        }

        /// <summary>
        /// Helper Method that searches a string for specific text. If specific strings are found they are interpreted as command line arguments
        /// and are passed as object attributes
        /// </summary>
        /// <param name="s">the string to search trhough</param>
        private void argumentHelper(string s)
        {
            if (s.Substring(1).StartsWith("app"))
            {
                Executable = s.Substring(5);
            }
            else if (s.Substring(1).StartsWith("args"))
            {
                Arguments = s.Substring(6);
            }
            else if (s.Substring(1).StartsWith("start"))
            {
                StartPoint = s.Substring(7);
            }
        }

        /// <summary>
        /// Method to launch an external executable from specific path with specifi arguments
        /// </summary>
        public void launch()
        {
            FileSearch fs = new FileSearch();
            fs.ProcessDirectory(StartPoint, Executable);
            string fullPathToExecutable = fs.FileName;

            Process p = new Process();
            p.StartInfo.FileName = fullPathToExecutable;
            p.StartInfo.Arguments = Arguments;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
        }
    }
}
