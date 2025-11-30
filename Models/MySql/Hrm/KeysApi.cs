using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class KeysApi
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public int Level { get; set; }
        public bool IgnoreLimits { get; set; }
        public int DateCreated { get; set; }
    }
}
