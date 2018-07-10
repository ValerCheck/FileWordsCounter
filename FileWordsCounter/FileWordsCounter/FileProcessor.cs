using System.IO;

namespace FileWordsCounter
{
    public class FileProcessor
    {
        public static bool TryGetFileContent(string fileName, out string content)
        {
            content = null;
            try
            {
                if (File.Exists(fileName))
                {
                    using (var streamReader = new StreamReader(File.Open(fileName, FileMode.Open)))
                    {
                        content = streamReader.ReadToEnd();
                    }
                    return true;
                }
                return false;
            }
            catch
            {
                content = null;
                return false;
            }
        }
    }
}
