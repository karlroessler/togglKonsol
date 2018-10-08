using System.Collections.Generic;

namespace TogglKonsol
{
    public class WriteTime_EntriesConsol : IWriteTime_EntriesConsol
    {
        private readonly IFormatTime_EntriesForConsol _formatTime_EntriesForConsol;
        private readonly IWriteConsol _writeConsol;

        public WriteTime_EntriesConsol(
            IFormatTime_EntriesForConsol formatTime_EntriesForConsol,
            IWriteConsol writeConsol)
        {
            _formatTime_EntriesForConsol = formatTime_EntriesForConsol;
            _writeConsol = writeConsol;
        }

        public void WriteTime(List<Time_entriesItem> list)
        {
            string output = _formatTime_EntriesForConsol.Format(list);
            _writeConsol.WriteLine(output);
        }
    }
}
