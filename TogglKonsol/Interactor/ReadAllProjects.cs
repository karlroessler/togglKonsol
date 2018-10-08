using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace TogglKonsol
{
    public class ReadAllProjects : IReadAllProjects
    {
        private readonly IGetConnectionToggl _getConnectionToggl;

        public ReadAllProjects(
            IGetConnectionToggl getConnectionToggl)
        {
            _getConnectionToggl = getConnectionToggl;
        }

        public List<ProjectsItem> ReadAll(List<Users> userList, List<Time_entriesItem> timeList)
        {
            List<ProjectsItem> allProjectList = new List<ProjectsItem>();

            IEnumerable<int> projectIds = timeList
                .Select(s => s.Pid)
                .Where(s => s != 0)
                .Distinct();

            foreach (Users item in userList)
            {
                string apitoken = item.ApiKey;
                foreach (int projectId in projectIds)
                {
                    string url = $"https://www.toggl.com/api/v8/projects/{projectId}";
                    string timejson = _getConnectionToggl.Get(apitoken, url);
                    ProjectsItem project = JsonConvert.DeserializeObject<ProjectsItem>(timejson);
                    if (project != null)
                    {
                        allProjectList.Add(project);
                    }
                }
            }
            return allProjectList;
        }
    }
}
