using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace TogglKonsol
{
    public class ConvertListToCSV : IConvertListToCSV
    {

        public string DetailedReportToCSV(List<Item> allDataList, List<Time_entriesItem> timeList, List<ProjectsItem> projectList, List<ClientsItem> clientsList)
        {
            //----- Atributes to fill the CSV -----//
            string user = null;
            string email = null;
            string client = null;
            string project = null;
            string task = null;
            string description = null;
            bool? billable = null;
            string startDate = null;
            string startTime = null;
            string endDate = null;
            string endTime = null;
            int? duration = null;
            string tags = null;
            string amount = null;

            //----- Other Atributes -----//
            string csv = null;
            string delimiter = ",";
            int projectID = 0;
            int workSpaceID = 0;



            csv = "User" + delimiter + "Email" + delimiter + "Client" + delimiter + "Project" + delimiter + "Task" + delimiter + "Description" + delimiter + "Billable" + delimiter + "Start date" + delimiter + "Start time" + delimiter + "End date" + delimiter + "End time" + delimiter + "Duration" + delimiter + "Tags" + delimiter + "Amount (EUR)" + Environment.NewLine;

            foreach (Item allData in allDataList)
            {
                user = allData.Data.Fullname;
                email = allData.Data.Email;
                workSpaceID = allData.Data.Default_wid; 

                if (timeList.Count > 0)
                {
                    foreach (Time_entriesItem timeItem in timeList)
                    {
                        if (workSpaceID == timeItem.Wid)
                        {
                            projectID = timeItem.Pid;
                            description = timeItem.Description;
                            billable = timeItem.Billable;
                            startDate = DateTime.Parse(timeItem.Start).ToString("yyyy-MM-dd");
                            startTime = DateTime.Parse(timeItem.Start).ToString("HH:mm:ss");
                            endDate = DateTime.Parse(timeItem.Stop).ToString("yyyy-MM-dd");
                            endTime = DateTime.Parse(timeItem.Start).ToString("HH:mm:ss");
                            duration = timeItem.Duration;

                            if (projectList.Count > 0)
                            {
                                foreach (ProjectsItem projectsItem in projectList)
                                {
                                    if (projectsItem.Id == projectID)
                                    {
                                        project = projectsItem.Name;
                                    }
                                }
                            }

                            if (clientsList.Count > 0)
                            {
                                foreach (ClientsItem clientsItem in clientsList)
                                {
                                    if (clientsItem.Wid == workSpaceID)
                                    {
                                        client = clientsItem.Name;
                                    }
                                }
                            }

                            //if (allData.Data.Tasks.Count > 0)
                            //{
                            //    foreach (TaskItem taskItem in allData.Data.Tasks)
                            //    {
                            //        if (taskItem.Wid == workSpaceID)
                            //        {
                            //            task = taskItem.Name;
                            //        }
                            //    }
                            //}

                            csv = csv + user + delimiter + email + delimiter + client + delimiter + project + delimiter + task + delimiter + description + delimiter + billable + delimiter + startDate + delimiter + startTime + delimiter + endDate + delimiter + endTime + delimiter + duration + delimiter + tags + delimiter + amount + Environment.NewLine;

                        }
                        
                    }

                }
                
            }
            

            return csv;
        }

        public string UserToCSV(List<Users> list)
        {
            return String.Join(",", list.Select(x => x.ToString()).ToArray());
        }

        public string ProjectToCSV(List<ProjectsItem> list)
        {
            return String.Join(",", list.Select(x => x.ToString()).ToArray());
        }

        public string Time_entriesToCSV(List<Time_entriesItem> list)
        {
            string csv = null;
            string x = ",";

            csv = "ID" + x + "Guid"+ x + "Wid" + x + "Pid" + x + "Billable" + x + "Start" + x + "Stop" + x + "Duration" + x + "Description" + x + "Duronly" + x + "At" + x + "Uid" + x + "Length" + Environment.NewLine;

            foreach (Time_entriesItem item in list)
            {
                csv = csv + item.Id + x + item.Guid + x + item.Wid + x + item.Pid + x + item.Billable + x + item.Start + x + item.Stop + x + item.Duration + x + item.Description + x + item.Duronly + x + item.At + x + item.Uid + x + item.Length + Environment.NewLine;
            }

            return csv;
        }
    }
}
