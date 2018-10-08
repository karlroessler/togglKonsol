using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace TogglKonsol
{
    public class ReadAllClients : IReadAllClients
    {
        private readonly IGetConnectionToggl _getConnectionToggl;

        public ReadAllClients(
            IGetConnectionToggl getConnectionToggl)
        {
            _getConnectionToggl = getConnectionToggl;
        }

        public List<ClientsItem> ReadClients(List<Users> userList, List<ProjectsItem> projectList)
        {
            ClientsItem client = new ClientsItem();
            HashSet<ClientsItem> allClientList = new HashSet<ClientsItem>();
            string url = null;
            string clientjson = null;

            foreach (Users item in userList)
            {
                string apitoken = item.ApiKey;
                foreach (ProjectsItem projectItem in projectList)
                {
                    if (projectItem.Cid != 0)
                    {
                        url = "https://www.toggl.com/api/v8/projects/" + projectItem.Cid;
                        clientjson = _getConnectionToggl.Get(apitoken, url);
                        client = JsonConvert.DeserializeObject<ClientsItem>(clientjson);
                        allClientList.Add(client);
                    }
                }
            }

            return allClientList.ToList();
        }
    }
}
