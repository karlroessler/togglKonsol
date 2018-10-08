using System.Collections.Generic;

namespace TogglKonsol
{
    public interface IWriteAllDataFromAllUserCSVFile
    {
        void SaveData(List<Item> allDataList, List<Time_entriesItem> timeList, List<ProjectsItem> projectsList, List<ClientsItem> clientsList, string filepath);
    }
}