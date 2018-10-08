using System;

namespace TogglKonsol
{
    public interface IReadCommandLineArguments
    {
        bool ReadEntries(string[] args);
        bool ReadHelp(string[] args);
        string ReadWrite(string[] args);
        string ReadTimeArea(string[] args);
        DateTime ReadStartDate(string[] args);
        DateTime ReadEndDate(string[] args);
    }
}