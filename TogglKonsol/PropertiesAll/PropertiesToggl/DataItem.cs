using System;
using System.Collections.Generic;

namespace TogglKonsol
{
    public class DataItem
    {
        public int Id { get; set; }
        public string Api_token { get; set; }
        public int Default_wid { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }
        public string Jquery_timeofday_format { get; set; }
        public string Timeofday_format { get; set; }
        public string Date_format { get; set; }
        public Boolean Store_start_and_stop_time { get; set; }
        public int Beginning_of_week { get; set; }
        public string Language { get; set; }
        public string Duration_format { get; set; }
        public string Image_url { get; set; }
        public string At { get; set; }
        public string Created_at { get; set; }
        public string Timezone { get; set; }
        public string Retention { get; set; }
        public BlogItem New_blog_post { get; set; }
        public List<ProjectsItem> Projects { get; set; }
        public List<TagsItem> Tags { get; set; }
        public List<TaskItem> Tasks { get; set; }
        public List<WorkspacesItem> Workspaces { get; set; }
        public List<Time_entriesItem> Time_entries { get; set; }
        public List<ClientsItem> Clients { get; set; }
    }
}
