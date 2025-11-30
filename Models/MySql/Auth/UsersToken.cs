using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Auth
{
    public partial class UsersToken
    {
        public ulong id { get; set; }
        public ulong user_id { get; set; }
        public string remember_token { get; set; } = null!;
        public int expired_time { get; set; }
        public DateTime expired_date { get; set; }
        public string? ip_address { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public DateTime? deleted_at { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
