using System.IO;

namespace TogglKonsol
{
    public class ReadJsonData : IReadJsonData
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
