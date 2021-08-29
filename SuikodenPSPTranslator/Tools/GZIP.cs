using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using System.Windows.Forms;

namespace SuikodenPSP.Tools
{
    public static class GZIP
    {
        public static string Extract(string filename)
        {
            // gzip extraction
            string res;
            // check if file exists
            if (!File.Exists(filename))
            {
                string message = $"File {filename} does not exist. Please create it.";
                MessageBox.Show(message);
                // exit app
                // https://stackoverflow.com/questions/12977924/how-to-properly-exit-a-c-sharp-application
                if (System.Windows.Forms.Application.MessageLoop)
                {
                    // WinForms app
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    // Console app
                    System.Environment.Exit(1);
                }
            }
            FileStream file = new FileStream(filename, FileMode.Open);
            using (var decompress = new GZipStream(file, CompressionMode.Decompress))
            using (var sr = new StreamReader(decompress))
            {
                res = sr.ReadToEnd();
            }
            return res;
        }

        public static void Compress(String file, String filename)
        {
            // gzip compression
            using (FileStream stream = File.OpenWrite(filename))
            {
                using (GZipStream gzip = new GZipStream(stream, CompressionLevel.Optimal))
                {
                    byte[] input = Encoding.UTF8.GetBytes(file);
                    gzip.Write(input, 0, input.Length);
                }

            }
        }
    }
}
