using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class Setting
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string Status { get; set; } = null!;
        public int UserC { get; set; }
        public int UserM { get; set; }
    }
}
