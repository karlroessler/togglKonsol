using System.Collections.Generic;

namespace TogglKonsol
{
    public interface IFormatTime_EntriesForConsol
    {
        string Format(List<Time_entriesItem> timelist);
    }
}