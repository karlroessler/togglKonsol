using System.Collections.Generic;

namespace TogglKonsol
{
    public class WriteTime_EntriesInCSVFile : IWriteTime_EntriesInCSVFile
    {
        private readonly IConvertListToCSV _convertListToCSV;
        private readonly IWriteFile _writeFile;

        public WriteTime_EntriesInCSVFile(
            IConvertListToCSV convertListToCSV,
            IWriteFile writeFile)
        {
            _convertListToCSV = convertListToCSV;
            _writeFile = writeFile;
        }

        public void SaveEntries(List<Time_entriesItem> list, string filepath)
        {
            string csv = _convertListToCSV.Time_entriesToCSV(list);
            _writeFile.CSVFile(csv, filepath);
        }
    }
}
