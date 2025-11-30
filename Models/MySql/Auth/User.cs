using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Auth
{
    public partial class User
    {
        public User()
        {
            UsersTokens = new HashSet<UsersToken>();
        }

        public ulong id { get; set; }
        public string name { get; set; } = null!;
        public string email { get; set; } = null!;
        public DateTime? email_verified_at { get; set; }
        public string password { get; set; } = null!;
        public string? two_factor_secret { get; set; }
        public string? two_factor_recovery_codes { get; set; }
        public DateTime? two_factor_confirmed_at { get; set; }
        public string? remember_token { get; set; }
        public sbyte is_active { get; set; }
        public sbyte is_need_change_password { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public int lang_id { get; set; }
        public ulong? employee_id { get; set; }
        public string grant_employee_type { get; set; } = null!;
        public long? employee_role_id { get; set; }

        public virtual ICollection<UsersToken> UsersTokens { get; set; }
    }
}
