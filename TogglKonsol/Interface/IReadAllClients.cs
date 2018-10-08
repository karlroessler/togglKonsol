using System.Collections.Generic;

namespace TogglKonsol
{
    public interface IReadAllClients
    {
        List<ClientsItem> ReadClients(List<Users> userList, List<ProjectsItem> projectList);
    }
}