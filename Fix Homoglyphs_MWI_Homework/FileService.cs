using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Fix_Homoglyphs_MWI_Homework
{
    internal class FileService
    {
        public string? importedFilePath { get; set; }
        public string? outputFilePath { get; set; }

        public FileService()
        {   
            AssemblePaths();
        }

        private void AssemblePaths()
        {
            Console.WriteLine("Please select a file to convert.");
            Thread.Sleep(1000);
            importedFilePath = GetFilePath();
            Console.WriteLine("Please select a file for converted output. \nIf you do not select a file, one will be created for you under the same parent folder as the input file.");
            Thread.Sleep(2000);
            outputFilePath = GetFilePath();
            if (string.IsNullOrEmpty(outputFilePath)) 
            {
                int extensionRemovalLength = importedFilePath.Length - 4;
                string defaultOutput = importedFilePath.Substring(0, extensionRemovalLength);           
                outputFilePath = Path.GetFullPath(defaultOutput);
                outputFilePath += "OUTPUT.txt";
            }
        }

        public static string GetFilePath()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            return ofd.FileName;    
        }
       
    }
}
