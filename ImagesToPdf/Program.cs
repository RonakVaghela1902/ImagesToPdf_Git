using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using SkiaSharp;
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading;

namespace ImagesToPdf
{
    internal class Program
    {
        static int quality = 90;
        static bool overRideQuality = true;
        static string outputFoldeName = "OutputPDFs";
        static string logFilePath;
        static void Main(string[] args)
        {
            string rootPath = null;
            string outputParentPath = null;

            if (args.Length == 0)
            {
                //Log("Please provide necessary arguments."
				Console.WriteLine("Please provide necessary arguments.");
                return;
            }
        }
    }
}
