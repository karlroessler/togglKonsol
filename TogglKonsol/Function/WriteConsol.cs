using System;

namespace TogglKonsol
{
    public class WriteConsol : IWriteConsol
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
