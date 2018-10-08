using System.Collections.Generic;

namespace TogglKonsol
{
    public interface IWriteTime_EntriesInCSVFile
    {
        void SaveEntries(List<Time_entriesItem> list, string filepath);
    }
}