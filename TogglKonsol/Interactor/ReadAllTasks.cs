using Newtonsoft.Json;
using System.Collections.Generic;

namespace TogglKonsol
{
    public class ReadAllTasks
    {
        private readonly IGetConnectionToggl _getConnectionToggl;

        public ReadAllTasks(
            IGetConnectionToggl getConnectionToggl)
        {
            _getConnectionToggl = getConnectionToggl;
        }

        public List<TaskItem> ReadAll(List<Users> userList, List<Time_entriesItem> timeList)
        {
            List<ProjectsItem> allProjectList = new List<ProjectsItem>();

            TaskItem task = new TaskItem();
            List<TaskItem> allTaskList = new List<TaskItem>();
            string url = null;
            string taskjson = null;

            foreach (Users item in userList)
            {
                string apitoken = item.ApiKey;
                foreach (Time_entriesItem timeItem in timeList)
                {
                    if (timeItem.Tid != 0)
                    {
                        url = "https://www.toggl.com/api/v8/tasks/" + timeItem.Tid;
                        taskjson = _getConnectionToggl.Get(apitoken, url);
                        task = JsonConvert.DeserializeObject<TaskItem>(taskjson);
                        allTaskList.Add(task);
                    }
                }
            }

            return allTaskList;
        }
    }
}
