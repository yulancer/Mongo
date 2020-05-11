// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Mongo
{
    using System;
    using System.IO;
    using System.Threading.Tasks;

    using NLog;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// имена файлов, которые необходимо прочесть.
        /// </summary>
        private static string[] FileNames { get; } = { "books.json", "books.csv", "books.xml" };

        /// <summary>
        /// The logger.
        /// </summary>
        private static Logger Logger { get; } = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public static async Task Main(string[] args)
        {
            Logger.Info("Start");

            foreach (string fileName in FileNames)
            {
                string fileContent = await ReadFromFile(fileName);
                Logger.Debug($"Из файла {fileName} прочитано {fileContent.Length} знаков");
            }
            
            Console.ReadKey();
            Logger.Info("Finish");
        }

        /// <summary>
        /// The read from file.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        private static async Task<string> ReadFromFile(string fileName)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(fileName))
                {
                    // Read the stream to a string, and write the string to the console.
                    string line = await sr.ReadToEndAsync();
                    Logger.Trace(line);
                    return line;
                }
            }
            catch (IOException e)
            {
                Logger.Error(e);
                return string.Empty;
            }
        }
    }
}