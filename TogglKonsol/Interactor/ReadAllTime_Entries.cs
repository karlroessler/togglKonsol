using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TogglKonsol
{
    public class ReadAllTime_Entries : IReadAllTime_Entries
    {
        private readonly IGetConnectionToggl _getConnectionToggl;

        public ReadAllTime_Entries(
            IGetConnectionToggl getConnectionToggl)
        {
            _getConnectionToggl = getConnectionToggl;
        }

        public List<Time_entriesItem> ReadAll(List<Users> userList, DateTime startDate, DateTime endDate)
        {
            List<Time_entriesItem> timeList = new List<Time_entriesItem>();
            List<Time_entriesItem> AllList = new List<Time_entriesItem>();
            string startTime = "00%3A00%3A00%2B01%3A00";
            string endTime = "00%3A00%3A00%2B01%3A00";


            foreach (Users item in userList)
            {
                string apitoken = item.ApiKey;
                string url = "https://www.toggl.com/api/v8/time_entries";
                url = url + "?start_date=" + startDate.ToString("yyyy-MM-dd") + "T" + startTime + "&end_date=" + endDate.ToString("yyyy-MM-dd") + "T" + endTime;
                string timejson = _getConnectionToggl.Get(apitoken, url);
                timeList = JsonConvert.DeserializeObject<List<Time_entriesItem>>(timejson);
                AllList.AddRange(timeList);
            }
            

            return AllList;
        }

    }
}
