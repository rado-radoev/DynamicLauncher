using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace DynamicLauncher
{
    /// <summary>
    /// This class recursively enumerates through a parent folder and all subfolders
    /// searching for a file that matches a specific pattern
    /// </summary>
    class FileSearch
    {
        // The full path to file
        private string fileName;

        public string FileName { get => fileName; set => fileName = value; }

        /// <summary>
        /// Method to process parent directory and all subfolders recursively searching for a file that matches a pattern
        /// The method will exit on the first file that matches the patter and will not continue to search further.
        /// </summary>
        /// <param name="directory">The parent directory to start the search from</param>
        /// <param name="searchPattern">The file to search for</param>
        public void ProcessDirectory(string directory, string searchPattern)
        {
            // Process the files in the current directory
            try
            {
                // Get all the files in the current directory that match the pattern
                IEnumerable<String> files = Directory.EnumerateFiles(directory, searchPattern);

                // If there are files that match the pattern in the current folder
                // set the fileName property to the full path and exit 
                if (files.Count() > 0)
                {
                    //Console.WriteLine(files.First());
                    FileName = files.First();
                    return;
                }

                // Loop through all the folders under the parent folder recursively
                string[] subdirectoryEntries = Directory.GetDirectories(directory);
                foreach (string dir in subdirectoryEntries)
                {
                    ProcessDirectory(dir, searchPattern);
                }
            }
            // exceptions ... are not really handled. we don't want to see messages for unaccessible folders, that's all
            // may be in a future version we can add messaged, but not that import right now
            catch (ArgumentNullException) { }
            catch (UnauthorizedAccessException) { }
            catch (PathTooLongException) { }
            catch (DirectoryNotFoundException) { }
        }
    }
}
