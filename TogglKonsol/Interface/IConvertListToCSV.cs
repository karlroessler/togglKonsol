using System.Collections.Generic;

namespace TogglKonsol
{
    public interface IConvertListToCSV
    {
        string UserToCSV(List<Users> list);
        string ProjectToCSV(List<ProjectsItem> list);
        string Time_entriesToCSV(List<Time_entriesItem> list);
        string DetailedReportToCSV(List<Item> allDataList, List<Time_entriesItem> timeList, List<ProjectsItem> projectList, List<ClientsItem> clientsList);
    }
}