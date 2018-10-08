using System;

namespace TogglKonsol
{
    public class ReadConsol : IReadConsol
    {
        public string ReadSentence()
        {
            return Console.ReadLine();
        }
    }
}
