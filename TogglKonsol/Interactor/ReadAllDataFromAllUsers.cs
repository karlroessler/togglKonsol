using Newtonsoft.Json;
using System.Collections.Generic;

namespace TogglKonsol
{
    public class ReadAllDataFromAllUsers : IReadAllDataFromAllUsers
    {
        private readonly IGetConnectionToggl _getConnectionToggl;

        public ReadAllDataFromAllUsers(
            IGetConnectionToggl getConnectionToggl)
        {
            _getConnectionToggl = getConnectionToggl;
        }

        public List<Item> ReadAll(List<Users> userlist)
        {
            Item userItem = new Item();
            List<Item> allInfoList = new List<Item>();
            List<Time_entriesItem> timeList = new List<Time_entriesItem>();
            List<ProjectsItem> projectList = new List<ProjectsItem>();
            

            foreach (Users item in userlist)
            {
                string apitoken = item.ApiKey;
                string alljson = _getConnectionToggl.Get(apitoken, "https://www.toggl.com/api/v8/me");
                userItem = JsonConvert.DeserializeObject<Item>(alljson);
                allInfoList.Add(userItem);
            }


            return allInfoList;
        }
    }
}
