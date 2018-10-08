using System.Collections.Generic;

namespace TogglKonsol
{
    public class WriteAllDataFromAllUserCSVFile : IWriteAllDataFromAllUserCSVFile
    {
        private readonly IConvertListToCSV _convertListToCSV;
        private readonly IWriteFile _writeFile;
        private readonly IWriteConsol _writeConsol;

        public WriteAllDataFromAllUserCSVFile(
            IConvertListToCSV convertListToCSV,
            IWriteFile writeFile,
            IWriteConsol writeConsol)
        {
            _convertListToCSV = convertListToCSV;
            _writeFile = writeFile;
            _writeConsol = writeConsol;
        }

        public void SaveData(List<Item> allDataList,List<Time_entriesItem> timeList,List<ProjectsItem> projectsList, List<ClientsItem> clientsList,string filepath)
        {
            string csv = _convertListToCSV.DetailedReportToCSV(allDataList,timeList, projectsList, clientsList);
            _writeFile.CSVFile(csv, filepath);
            _writeConsol.WriteLine("Die Datei CSV wurde in " + filepath + " gespeichert");
        }
    }
}
