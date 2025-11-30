namespace AdidataDbContext.Models.MySql.Auth
{
    public partial class LoginAttempt
    {
        public long id { get; set; }
        public long? user_id { get; set; }
        public string name { get; set; } = null!;
        public string? info_api { get; set; }
        public string? paths { get; set; }
        public DateTime? attempt_time { get; set; }
        public string? error_type { get; set; }
        public string? user_agent { get; set; }
        public string? ip_address { get; set; }
        public string? mac_address { get; set; }
        public string? hostname { get; set; }
    }
}
