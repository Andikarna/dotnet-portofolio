using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Auth
{
    public partial class Log
    {
        public ulong id { get; set; }
        public string logs { get; set; } = null!;
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
    }
}
