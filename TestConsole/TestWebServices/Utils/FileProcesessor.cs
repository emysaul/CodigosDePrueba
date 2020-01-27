using System.IO;

namespace TestWebServices.Utils
{
    public class FileProcesessor
    {
        public string ReadAllTextFromFile(string file)
        {
            return File.ReadAllText(file);
        }
    }
}
