using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class Project
    {
        public int id { get; set; }
        public int client_id { get; set; }
        public string name { get; set; } = null!;
        public bool leaves_sub { get; set; }
        public string status { get; set; } = null!;
        public int user_c { get; set; }
        public int? user_m { get; set; }
        public DateTime created_date { get; set; }
        public DateTime? modified_date { get; set; }
    }
}
