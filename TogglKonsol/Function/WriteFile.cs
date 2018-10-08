using System;
using System.IO;

namespace TogglKonsol
{
    public class WriteFile : IWriteFile
    {
        public bool CSVFile(string Text, string filePath)
        {
            bool successful = false;
            try
            {
                Uri path = new Uri(filePath);
                FileInfo file = new FileInfo(filePath);
                file.Directory.Create();
                File.WriteAllText(filePath, Text);
                successful = true;
            }
            catch
            {
                successful = false;
            }
            return successful;
        }
    }
}
