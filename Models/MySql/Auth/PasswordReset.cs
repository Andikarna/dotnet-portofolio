using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Auth
{
    public partial class PasswordReset
    {
        public ulong Id { get; set; }
        public string? Email { get; set; }
        public string? CurrentPassword { get; set; }
        public string? NewPassword { get; set; }
        public string? ReNewPassword { get; set; }
        public string? Token { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
