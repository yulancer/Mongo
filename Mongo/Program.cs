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
            Console.ReadKey();
            Logger.Info("Finish");
        }
    }
}