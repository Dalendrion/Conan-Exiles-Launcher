using Conan_Exiles_Launcher.Data;
using System.Text;

namespace Conan_Exiles_Launcher.Core.Adapters.Files
{
    internal class FileLineReader
    {
        private readonly FileLineProcessor _lineProcessor;

        public FileLineReader(FileLineProcessor lineProcessor)
        {
            _lineProcessor = lineProcessor;
        }

        public void ReadFile(string filePath)
        {
            using (FileStream fileStream = getFile(filePath))
            {
                using (StreamReader streamreader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
                {
                    String line;
                    while ((line = streamreader.ReadLine()) != null)
                    {
                        _lineProcessor.ProcessLine(line);
                    }
                }
            }
        }

        private FileStream getFile(string path)
        {
            return File.OpenRead(path);
        }
    }
}