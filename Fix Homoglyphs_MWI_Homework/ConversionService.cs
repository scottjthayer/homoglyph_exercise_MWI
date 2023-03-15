using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Fix_Homoglyphs_MWI_Homework
{
    internal class ConversionService
    {
        public static void RunConversion()
        {
            try
            {
                FileService fileService = new FileService();
                using var stream = GetStream(fileService);
                WriteConversion(stream, fileService);
                Console.WriteLine("\nConversion complete! Your file is located at:");
                Console.WriteLine(fileService.outputFilePath);
                Console.ReadKey();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
                Console.WriteLine("Program had serious issues... speak with your dev.");
            }
        }

        public static StreamReader GetStream(FileService fileService)
        {
            var stream = new StreamReader(File.OpenRead(fileService.importedFilePath));
            return stream;
        }

        public static void WriteConversion(StreamReader reader, FileService fileService)
        {
            string line = "";
            using (StreamWriter writer = File.CreateText(fileService.outputFilePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    char[] lineToEdit = line.ToArray();
                    //Console.WriteLine(line);
                    line = ConvertLine(lineToEdit);
                    //add line to output file
                    writer.WriteLine(line);
                }
            }
        }

        private static string ConvertLine(char[] lineToEdit)
        {
            try
            {
                int i = 0;
                string edittedLine = "";
                var homoglyphsToConvert = CharactersRepository.GetDictionary();
                foreach (char c in lineToEdit)
                {
                    if (homoglyphsToConvert.Keys.Any(k => k.Equals(c)))
                    {
                        //find conversion
                        char characterForOutput = homoglyphsToConvert[c];
                        //convert
                        lineToEdit[i] = characterForOutput;
                        //build string for output
                        edittedLine = new string(lineToEdit);
                    }
                    i++;
                }
                return edittedLine;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return "Line could not be converted... please contact support";
            }

        }
    }
}
