using System.Collections.Generic;

namespace TogglKonsol
{
    public interface IReadAllProjects
    {
        List<ProjectsItem> ReadAll(List<Users> userList, List<Time_entriesItem> timeList);
    }
}