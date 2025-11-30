using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Auth
{
    public partial class UserLog
    {
        public ulong Id { get; set; }
        public ulong user_id { get; set; }
        public string name { get; set; } = null!;
        public string? url { get; set; }
        public string? ip_address { get; set; }
        public string? mac_address { get; set; }
        public string? hostname { get; set; }
        public string? browser { get; set; }
        public DateTime? created_at { get; set; }
    }
}
