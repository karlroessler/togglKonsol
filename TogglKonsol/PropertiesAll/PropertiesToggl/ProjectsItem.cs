using System;

namespace TogglKonsol
{
    public class ProjectsItem
    {
        public int Id { get; set; }
        public int Template_id { get; set; }
        public string Wid { get; set; }
        public int Cid { get; set; }
        public string Name { get; set; }
        public Boolean Billable { get; set; }
        public Boolean Is_private { get; set; }
        public Boolean Active { get; set; }
        public Boolean Template { get; set; }
        public string At { get; set; }
        public string Created_at { get; set; }
        public int Color { get; set; }
        public Boolean Auto_estimates { get; set; }
        public int Actual_hours { get; set; }
        public string Hex_color { get; set; }
    }
}
