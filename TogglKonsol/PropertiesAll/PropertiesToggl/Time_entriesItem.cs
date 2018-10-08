using System;

namespace TogglKonsol
{
    public class Time_entriesItem
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public int Wid { get; set; }
        public int Pid { get; set; }
        public int Tid { get; set; }
        public Boolean Billable { get; set; }
        public string Start { get; set; }
        public string Stop { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public Boolean Duronly { get; set; }
        public string At { get; set; }
        public int Uid { get; set; }
        public int Length { get; internal set; }
    }
}
